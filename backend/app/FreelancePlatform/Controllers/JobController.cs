using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FreelancePlatform.Data;
using FreelancePlatform.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace FreelancePlatform.Controllers
{
    public class JobController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public JobController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("jobs")]
        public IActionResult Index()
        {
            var jobs = _context.Jobs.ToList();

            return View(jobs);
        }

        [Route("jobs/create")]
        [Authorize(Roles = "Client")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("jobs/save")]
        [Authorize(Roles = "Client")]
        [HttpPost]
        public async Task<IActionResult> Save(Job model)
        {
            if (ModelState.IsValid)
            {
                TempData["type"] = "Me sukses!";
                TempData["message"] = "Shpallja juaj u publikua me sukses!";
                //_logger.LogInformation(model.ToString());
                var user = await _userManager.GetUserAsync(HttpContext.User);
                model.User = user;
                _context.Jobs.Add(model);

                await _context.SaveChangesAsync();

                return RedirectToActionPermanent("Index", "Home");
            }

            return View("Create", model);
        }

        [HttpPost]
        [Authorize(Roles = "Freelancer")]
        public async Task<IActionResult> Apply(int id)
        {
            var job = _context.Jobs.SingleOrDefault(x => x.Id == id);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return RedirectToActionPermanent("Login", "Account");
            }
            else
            {
                if (!User.IsInRole("Freelancer"))
                {
                    TempData["message"] = "Ju s'mund ta kryeni këtë veprim";
                    return RedirectToActionPermanent("JobDetails", "Home", new { id });
                }
            }
            var apply = new Applicant
            {
                User = user,
                Job = job,
                CreatedAt = DateTime.Now
            };

            _context.Applicants.Add(apply);

            await _context.SaveChangesAsync();

            return RedirectToActionPermanent("JobDetails", "Home", new { id });
        }

        [Route("mark-as-filled/{id}")]
        [Authorize(Roles = "Client")]
        public async Task<IActionResult> MarkAsFilled(int id)
        {
            var job = _context.Jobs.SingleOrDefault(x => x.Id == id);
            job.Filled = true;
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();

            return RedirectToActionPermanent("Index", "Dashboard");
        }

        [HttpPost]
        [Authorize(Roles = "Client")]
        [Route("employer/jobs/{id}/destroy")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Destroy(int id)
        {
            var job = _context.Jobs.SingleOrDefault(x => x.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();

            TempData["type"] = "Me sukses!";
            TempData["message"] = "Shpallja e fshi me sukses!";

            return RedirectToActionPermanent("Index", "Dashboard");
        }


        [HttpGet]
        [Route("jobs/search")]

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        [Route("jobs/search")]
        public async Task<IActionResult> Search(ClientInputModel model)

        {

            if (ModelState.IsValid)

            {

                var client_input = new

                {

                    title = model.Title,

                    description = model.Description,

                    skills = model.Skills,

                    duration = model.Duration,

                    budget = model.Budget

                };

                // Call the Python script with the client_input data

                using (var httpClient = new HttpClient())

                {

                    var response = await httpClient.PostAsJsonAsync("http://localhost:5000/api/python", client_input);

                    if (response.IsSuccessStatusCode)

                    {

                        var result = await response.Content.ReadFromJsonAsync<dynamic>();

                        return Ok(result);

                    }

                    else

                    {

                        return StatusCode((int)response.StatusCode, response.ReasonPhrase);

                    }

                }

            }

            return BadRequest(ModelState);

        }

    }

}





