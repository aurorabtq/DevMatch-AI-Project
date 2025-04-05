using FreelancePlatform.Services;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

public class EmailService : IEmailService
{
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
        _config = config;
    }

    // For Identity confirmation and password reset links
    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        var message = new MimeMessage();
        message.From.Add(MailboxAddress.Parse(_config["MailSettings:SenderEmail"]));
        message.To.Add(MailboxAddress.Parse(email));
        message.Subject = subject;

        var bodyBuilder = new BodyBuilder
        {
            HtmlBody = htmlMessage
        };

        message.Body = bodyBuilder.ToMessageBody();

        using var smtp = new MailKit.Net.Smtp.SmtpClient();
        await smtp.ConnectAsync(_config["MailSettings:Server"], int.Parse(_config["MailSettings:Port"]), true);
        await smtp.AuthenticateAsync(_config["MailSettings:SenderEmail"], _config["MailSettings:Password"]);
        await smtp.SendAsync(message);
        await smtp.DisconnectAsync(true);
    }
    public async Task SendEmailWithAttachmentAsync(string toEmail, string subject, string body, byte[] attachment, string filename)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config["MailSettings:SenderEmail"]));
        email.To.Add(MailboxAddress.Parse(toEmail));
        email.Subject = subject;

        var builder = new BodyBuilder
        {
            HtmlBody = body
        };

        builder.Attachments.Add(filename, attachment, ContentType.Parse("application/pdf"));

        email.Body = builder.ToMessageBody();

        using var smtp = new MailKit.Net.Smtp.SmtpClient();
        await smtp.ConnectAsync(_config["MailSettings:Server"], int.Parse(_config["MailSettings:Port"]), true);
        await smtp.AuthenticateAsync(_config["MailSettings:SenderEmail"], _config["MailSettings:Password"]);
        await smtp.SendAsync(email);
        await smtp.DisconnectAsync(true);
    }
}
