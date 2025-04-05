using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using FreelancePlatform.Models;
using FreelancePlatform.Services;

namespace FreelancePlatform.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailService _emailSender;
        RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailService emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

public class InputModel
{
    [Required]
    [Display(Name = "Emri")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "Mbiemri")]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Fjalëkalimi")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Konfirmo fjalëkalimin")]
    [Compare("Password", ErrorMessage = "Fjalëkalimi nuk po përputhet.")]
    public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "Role")]
            public string Name { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ViewData["roles"] = _roleManager.Roles.ToList();
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
if (ModelState.IsValid)
{
    MailAddress address = new MailAddress(Input.Email);
    string userName = address.User;
                var role = _roleManager.FindByIdAsync(Input.Name).Result;
                var user = new ApplicationUser 
    { 
        UserName = userName, 
        Email = Input.Email,
        FirstName = Input.FirstName,
        LastName = Input.LastName,
        };

var result = await _userManager.CreateAsync(user, Input.Password);
if (result.Succeeded)
{
    _logger.LogInformation("Përdoruesi krijoi një llogari të re me fjalëkalim.");
                    await _userManager.AddToRoleAsync(user, role.Name);

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
    var callbackUrl = Url.Page(
        "/Account/ConfirmEmail",
        pageHandler: null,
        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
        protocol: Request.Scheme);

    await _emailSender.SendEmailAsync(Input.Email, "Ju lutem konfirmoni fjalëkalimin tuaj",
        $"Ju lutem konfirmoni fjalëkalimin tuaj duke <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>klikuar këtu.</a>.");

    if (_userManager.Options.SignIn.RequireConfirmedAccount)
    {
        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
    }
    else
    {
        await _signInManager.SignInAsync(user, isPersistent: false);
        return LocalRedirect(returnUrl);
    }
}
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
