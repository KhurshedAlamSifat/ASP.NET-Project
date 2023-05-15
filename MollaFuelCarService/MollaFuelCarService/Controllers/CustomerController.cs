using BLL.DTOs.CustomerDTOs;
using BLL.Services.CustomerServices;
using MollaFuelCarService.Authenticate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MollaFuelCarService.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customers")]
        public HttpResponseMessage Customers()
        {
            try
            {
                var data = CustomerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [Logged]
        [HttpGet]
        [Route("api/customers/{username}")]
        public HttpResponseMessage Customers( string username)
        {
            try
            {
                var data = CustomerService.Get(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/customers/add")]
        public HttpResponseMessage CustomersAdd(CustomerDTO customer)
        {
            string senderEmail = "mollasfuel@gmail.com";
            string senderPassword = "oulcgsufebduckez";
            string recipientEmail = customer.Email;
            string subject = "Welcome to Our Molla Fuel And Car Service!";
            string body = "<div style=\"font-family: Arial, sans-serif; font-size: 14px; color: #0d0d0d; font-weight: 300;\">"
                  + "<h4>Dear " + customer.Name + ",</h4>"
                  + "<p>Thank you for signing up with Molla Fuel And Car Service. We are thrilled to have you as a member of our community! " +
                  "We believe that our service will benefit, and we can't wait to see the impact that you'll make with it." +
                  "If you have any questions or need assistance, please don't hesitate to reach out to us at [mollasfuel@gmail.com]. We're here to help!</p>"
                  + "<p>Once again, welcome to Molla Fuel And Car Service, and thank you for choosing us.</p>"
                  + "<h4>Best regards,</h4>"
                  + "<h3>MOLLA FUEL AND CAR SERVICE</h3>"
                  + "</div>";
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true,
            };

            var message = new MailMessage(senderEmail, recipientEmail, subject, body)
            {
                IsBodyHtml = true
            };

            smtpClient.Send(message);
            try
            {
                var data = CustomerService.Insert(customer);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/customers/{username}/update")]
        public HttpResponseMessage CustomersUpdate(CustomerDTO username)
        {
            try
            {
                var data = CustomerService.Update(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/customers/{username}/delete")]
        public HttpResponseMessage CustomersDelete(string username)
        {
            try
            {
                var data = CustomerService.Delete(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/customers/{username}/order")]
        public HttpResponseMessage CustomersOrder(string username)
        {
            try
            {
                var data = CustomerService.CustomersOrders(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/customers/{username}/order/delete")]
        public HttpResponseMessage CustomersOrdesDelete(string username)
        {
            try
            {
                var data = CustomerService.OrderDelete(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/customers/{username}/fuelorder")]
        public HttpResponseMessage CustomersFuelOrder(string username)
        {
            try
            {
                var data = CustomerService.CustomersOrders(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/customers/{username}/fuelorder/delete")]
        public HttpResponseMessage CustomersFuelOrdesDelete(string username)
        {
            try
            {
                var data = CustomerService.OrderDelete(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/customers/count")]
        public HttpResponseMessage CustomersCount()
        {
            try
            {
                var data = CustomerService.Get().Count;
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

    }
}
