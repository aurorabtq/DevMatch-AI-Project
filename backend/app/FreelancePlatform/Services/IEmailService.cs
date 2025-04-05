using System.Threading.Tasks;

namespace FreelancePlatform.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
        Task SendEmailWithAttachmentAsync(string toEmail, string subject, string body, byte[] attachment, string filename);
    }
}
