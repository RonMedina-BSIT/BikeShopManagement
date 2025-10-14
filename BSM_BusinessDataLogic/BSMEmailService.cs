using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using BSM_DataService;
using BSM_Common;

namespace BSM_BusinessDataLogic
{
  public class BSMEmailService
    {
       public void SendEmail(Bikeparts GetAllBikes)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Bike Shop System", "bikeshop@test.com"));
            message.To.Add(new MailboxAddress("Ron Test Inbox", "test@inbox.mailtrap.io"));
            message.Subject = "Available Bikes";
            message.Body = new TextPart("plain")
            {

                Text ="There is the new Available Bike!!!\n\n"+
                $"Bike Type: {GetAllBikes.BikeType}\n" +
                $"Brand: {GetAllBikes.Brand}\n" +
                $"Price: {GetAllBikes.Price}\n" +
                $"Frameset: {GetAllBikes.Frameset}\n" +
                $"Groupset: {GetAllBikes.Groupset}\n" +
                $"Wheelset: {GetAllBikes.Wheelset}\n\n" + 
                "Get this now before it's too late!"
            };
            using (var client=new SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var tls=MailKit.Security.SecureSocketOptions.StartTls;
                client.Connect(smtpHost, smtpPort, tls);

                var userName = "6a2fa64ffaa0b4";
                var password = "363e415d45f55b";

                client.Authenticate(userName, password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
