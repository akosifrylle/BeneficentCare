using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BeneficentCare.Services
{
    public class MailService
    {
        public async Task<string> SendMessage(Customer customer)
        {

            var task = Task<string>.Run(async () =>
            {
                var message = new MailMessage()
                {
                    From = new MailAddress(customer.Email, $"Assessment - {customer.FirstName}, {customer.LastName}"),
                    Subject = string.Format("Assessment - {0}, {1}", customer.FirstName, customer.LastName),
                    Body = customer.Question,
                    IsBodyHtml = false
                };

                message.To.Add(new MailAddress("akosifrylle@gmail.com"));  // replace with valid value 

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "akosifrylle@gmail.com",  // replace with valid value
                        Password = "123Jumong123"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    try
                    {
                        await smtp.SendMailAsync(message);
                        return "Mail has been successfully sent!";
                    }
                    catch (Exception ex)
                    {
                        var error = "Fail Has error" + ex.Message;
                        return error;
                    }
                }
            });

            var result = task.Result;
            return result;
        }
    }
}
