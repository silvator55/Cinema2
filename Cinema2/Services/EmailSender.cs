using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Cinema2.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            System.Diagnostics.Debug.WriteLine($"To: {email} | Subject: {subject} | Message: {htmlMessage}");
            return Task.CompletedTask;
        }
    }
}