using Business.Interface;
using Business.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Business.Concrete
{
    public class EmailManager : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailManager(IOptions<EmailSettings> options)
        {
            _emailSettings = options.Value;
        }

        public  async Task MailGonder(string Email)
        {
            var smptClient = new SmtpClient();

            smptClient.Host = _emailSettings.Host;
            smptClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smptClient.UseDefaultCredentials = false;
            smptClient.Port = 587;
            smptClient.Credentials = new NetworkCredential(_emailSettings.Email, _emailSettings.Password);
            smptClient.EnableSsl = true;
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_emailSettings.Email);
            mailMessage.To.Add(Email);
            mailMessage.Subject = " Bilgilendirme|Hat Oanylama İşlemi";
            mailMessage.Body = @$"
                  <h4>Hattınız Onaylanmıştır..</h4>";
            mailMessage.IsBodyHtml = true;
            await smptClient.SendMailAsync(mailMessage);
        }
    }
}
