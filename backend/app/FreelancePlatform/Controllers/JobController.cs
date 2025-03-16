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
using System.Diagnostics;
using System.Text.Json;

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

                        // Read the response content as a string
                        var responseContent = await response.Content.ReadAsStringAsync();

                      
                            // Deserialize the content into a dynamic object if needed
                            var dynamicResult = JsonSerializer.Deserialize<dynamic>(responseContent);

                            // Deserialize the content into a List<TopMatchViewModel>
                            var topMatches = JsonSerializer.Deserialize<List<TopMatchViewModel>>(responseContent);

                            // Return the view with topMatches data
                            return View("TopMatches", topMatches);
                        




                    }

                    else

                    {

                        return StatusCode((int)response.StatusCode, response.ReasonPhrase);

                    }

                }

            }

            return BadRequest(ModelState);

        }


     
        [Route("jobs/start")]
        public async Task<IActionResult> RunPythonScript()
        {
            // Prepare the command to run the Python script
            var pythonScriptPath = "../../../ai/training/model_training.py";  // Adjust the path to your script
            var pythonExePath = "python"; // Ensure Python is in your PATH, or use the full path

            // Prepare the arguments (if needed, such as passing input data)
            string arguments = pythonScriptPath;

            try
            {
                // Start the process
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = pythonExePath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(processStartInfo))
                {
                    // Capture the output and errors
                    var output = await process.StandardOutput.ReadToEndAsync();
                    var error = await process.StandardError.ReadToEndAsync();

                    // Wait for the script to finish execution
                    await process.WaitForExitAsync();

                    if (process.ExitCode == 0)
                    {
                        // Return successful response with the script output
                        return Ok(new { status = "success", output = output });
                    }
                    else
                    {
                        // Return error response with the script error
                        return StatusCode(500, new { status = "error", message = error });
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                return StatusCode(500, new { status = "error", message = ex.Message });
            }
        }

    }

}





