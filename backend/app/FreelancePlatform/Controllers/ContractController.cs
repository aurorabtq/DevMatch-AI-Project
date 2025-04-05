using FreelancePlatform.Data;
using FreelancePlatform.Models;
using FreelancePlatform.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System.Linq;
using FreelancePlatform.Services;

namespace FreelancePlatform.Controllers
{
    public class ContractController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailService _emailService;

        public ContractController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,IEmailService emailService)
        {
            _context = context;
            _userManager = userManager;
            _emailService = emailService;
        }

        public async Task<IActionResult> Create(int jobId, string freelancerId)
        {
            var job = await _context.Jobs.Include(j => j.User).FirstOrDefaultAsync(j => j.Id == jobId);
            var freelancer = await _userManager.FindByIdAsync(freelancerId);

            if (job == null || freelancer == null)
                return NotFound();

            var viewModel = new ContractViewModel
            {
                JobId = jobId,
                FreelancerId= freelancerId,
                ClientName = job.User.FirstName+" "+ job.User.LastName,
                FreelancerName = freelancer.FirstName+ " "+ freelancer.LastName,
                Terms = $"This contract is between {job.User.FirstName + " " + job.User.LastName} and {freelancer.FirstName + " " + freelancer.LastName} for the job '{job.Title}'."
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContractViewModel model)
        {
            var client = await _userManager.GetUserAsync(User);

            var contract = new Contract
            {
                JobId = model.JobId,
                ClientId = client.Id,
                FreelancerId = model.FreelancerId, 
                Terms = model.Terms,
                CreatedAt = DateTime.UtcNow,
                Status = "Draft"
            };

            _context.Contracts.Add(contract);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = contract.Id });
        }

        public async Task<IActionResult> Details(int id)
        {
            var contract = await _context.Contracts
                .Include(c => c.Job)
                .Include(c => c.Client)
                .Include(c => c.Freelancer)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (contract == null)
                return NotFound();

            return View(contract);
        }

        public IActionResult ExportPdf(int id)
        {
            var contract = _context.Contracts
                .Include(c => c.Job)
                .Include(c => c.Client)
                .Include(c => c.Freelancer)
                .FirstOrDefault(c => c.Id == id);

            if (contract == null)
                return NotFound();

            return new ViewAsPdf("Pdf", contract)
            {
                FileName = $"Contract_{contract.Id}.pdf"
            };
        }
        [HttpPost]
        public async Task<IActionResult> SignContract(int id)
        {
            var contract = await _context.Contracts
                .Include(c => c.Job)
                .Include(c => c.Client)
                .Include(c => c.Freelancer)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (contract == null)
                return NotFound();

            contract.SignedAt = DateTime.UtcNow;
            contract.Status = "Signed";

            await _context.SaveChangesAsync();

            // Generate PDF
            var pdfResult = new ViewAsPdf("Pdf", contract);
            var pdfBytes = await pdfResult.BuildFile(ControllerContext);

           
            var subject = "Freelance Contract Signed";
            var message = $"Dear {contract.Freelancer.FirstName},<br/>The contract for job <strong>{contract.Job.Title}</strong> has been signed.<br/><br/>Best regards,<br/>Freelance Platform";

          
           // await _emailService.SendEmailWithAttachmentAsync(contract.Client.Email, subject, message, pdfBytes, $"Contract_{contract.Id}.pdf");
           // await _emailService.SendEmailWithAttachmentAsync(contract.Freelancer.Email, subject, message, pdfBytes, $"Contract_{contract.Id}.pdf");

            return RedirectToAction("Details", new { id });
        }
    }

}
