using System.Linq;
using System.Threading.Tasks;
using FreelancePlatform.Data;
using FreelancePlatform.Models;
using FreelancePlatform.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FreelancePlatform.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;

        public DashboardController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            ILogger<DashboardController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

        [Route("client/dashboard")]
        [Authorize(Roles = "Client")]
        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var jobs = _context.Jobs.Where(x => x.User == user).Include(x => x.Applicants).ToList();
            //var model = await PagingList.CreateAsync(jobs, 2, page);

            return View(jobs);
        }

        [Route("client/applicants")]
        public async Task<IActionResult> Applicants()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var applicants = _context.Applicants.Where(x => x.Job.User == user).Include(x => x.User).Include(x => x.Job)
                .ToList();

            return View(applicants);
        }

        [Route("clientsa/jobs/{id}/applicants")]
        public async Task<IActionResult> ApplicantsByJob(int id)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var job = _context.Jobs
                .Include(x => x.Applicants)
                    .ThenInclude(x => x.User)
                .SingleOrDefault(x => x.Id == id);
            //            _logger.LogInformation(job.Title);
            var model = new JobApplicantsViewModel
            {
                Job = job,
                Applicants = job.Applicants
            };

            return View(model);
        }
    }
}