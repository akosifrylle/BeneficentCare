using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using BeneficentCare.Services;

namespace BeneficentCare.Web.Controllers.Api
{
    [RoutePrefix("api/customer")]
    public class CustomerController: ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetCustomer()
        {
            var customer = new Customer
            {
                Address = "Madelaine",
                Email = "akosifrylle@yahoo.com",
                FirstName = "Frylle Jasper",
                LastName = "Bancaso",
                PreferredTime = "2 PM",
                Question = "How can we contact you"
            };

            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }

        [HttpPost]
        [Route("contact")]
        public async Task<HttpResponseMessage> Contact(Customer customer)
        {
            var mailService = new MailService();

            var message = await mailService.SendMessage(customer);

            return Request.CreateResponse(HttpStatusCode.OK, message);
        }

        public async void TestMethod()
        {
            await Task.Run(LongTask);
        }

        public void LongTask()
        {
            Thread.Sleep(5000);
        }

    }
}