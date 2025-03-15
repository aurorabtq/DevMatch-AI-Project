using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreelancePlatform.Models;

using System.Net;
using System.Net.Mail;

using Microsoft.AspNetCore.Identity;
using FreelancePlatform.Data;
using FreelancePlatform.ViewModels;


namespace FreelancePlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            ViewData["UserCount"] = _context.Users.Count();
            ViewData["JobCount"] = _context.Jobs.Count();
            ViewData["ApplicantCount"] = _context.Applicants.Count();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PostJob()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public string SendEmail(string Name, string Email, string Message)
        {

            try
            {
                // Credentials
                var credentials = new NetworkCredential("your-email@gmail.com", "your-password");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("noreply@codinginfinite.com"),
                    Subject = "Email Sender App",
                    Body = Message
                };
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(Email));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("jobs/{id}/details")]
        public async Task<IActionResult> JobDetails(int id)
        {
            //ViewBag.message = "You can't do this action";
            var job = _context.Jobs.SingleOrDefault(x => x.Id == id);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var applied = false;
            if (user != null)
                applied = _context.Applicants.Where(x => x.Job == job).Any(x => x.User == user);

            var model = new JobDetailsViewModel
            {
                Job = job,
                IsApplied = applied
            };
            return View(model);
        }

        [Route("search")]
        public IActionResult Search()
        {
            List<Job> jobs;

            string position = HttpContext.Request.Query["position"].ToString();
            string location = HttpContext.Request.Query["location"].ToString();
            if (position.Length > 0 && location.Length > 0)
            {
                jobs = _context.Jobs.Where(x => x.Title.Contains(position))
                    .ToList();
            }
            else if (location.Length == 0)
            {
                jobs = _context.Jobs.Where(x => x.Title.Contains(position))
                    .ToList();
            }
            else
            {
                jobs = _context.Jobs.Where(x => x.Location.Contains(location))
                    .ToList();
            }


            return View(jobs);
        }

    }
}
