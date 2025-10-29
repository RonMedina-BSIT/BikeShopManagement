using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using BSM_DataService;
using BSM_Common;
using Microsoft.Extensions.Configuration;
using MailKit.Security;


namespace BSM_BusinessDataLogic
{
  public class BSMEmailService
    {
        private readonly IConfiguration _configuration;
        public BSMEmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SendEmail(Bikeparts GetAllBikes, string recipientEmail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_configuration["EmailSettings:FromName"], _configuration["EmailSettings:FromEmail"]));
            message.To.Add(new MailboxAddress("Test Inbox", recipientEmail));
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
                client.Connect(
                    _configuration["EmailSettings:SmtpHost"],
                    int.Parse(_configuration["EmailSettings:SmtpPort"]),
                    SecureSocketOptions.StartTls
                    );
                client.Authenticate(
                    _configuration["EmailSettings:Username"],
                    _configuration["EmailSettings:Password"]
                    );
                client.Send(message);
                client.Disconnect(true);

            }
        }
    }
}
