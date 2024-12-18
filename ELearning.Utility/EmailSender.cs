using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace ELearning.Utility
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret { get; set; }

        public EmailSender(IConfiguration _config)
        {
            SendGridSecret = _config["SendGrid:SecretKey"];
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            var client = new SendGridClient(SendGridSecret);

            var from = new EmailAddress("wesik19710@chosenx.com", "Admin Elearning");
            var to = new EmailAddress(email, "Student User");
            var message = MailHelper.CreateSingleEmail(from, to, subject, "test content", htmlMessage);

            var response = await client.SendEmailAsync(message).ConfigureAwait(false);
        }
    }
}
