using System.Threading.Tasks;

namespace FreelancePlatform.Services
{
    public interface IEmailService
    {
        Task SendEmailWithAttachmentAsync(string toEmail, string subject, string body, byte[] attachment, string filename);
    }
}
