using BLL.DTOs.AdminDTOs;
using BLL.Services.AdminServices;

using MollaFuelCarService.Authenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services.Description;

namespace MollaFuelCarService.Controllers
{

    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {
        
       
        [HttpGet]
        [Route("api/admins")]
        public HttpResponseMessage Admins()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [Logged]
        [HttpGet]
        [Route("api/admins/{id}")]
        public HttpResponseMessage Admin(string username)
        {
            try
            {
                var data = AdminService.Get(username);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/admins/add")]
        public HttpResponseMessage ADD_Admin(AdminDTO admin)
        {
            try
            {
                var data = AdminService.Insert(admin);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
      //  [Logged]
        [HttpPost]
        [Route("api/admins/{id}/update")]
        public HttpResponseMessage Update_Admin(AdminDTO admin)
        {
            try
            {
                var data = AdminService.Updated(admin); return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
       // [Logged]
        [HttpPost]
        [Route("api/admins/{id}/delete")]
        public HttpResponseMessage Delete_Admin(string username)
        {
            try
            {
                var data = AdminService.Delete(username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

       // [Logged]
        [HttpGet]
        [Route("api/admins/product")]
        public HttpResponseMessage Product()
        {
            try
            {
                var data = ProductService.GetProduct();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
      //  [Logged]
        [HttpGet]
        [Route("api/products/{id}")]
        public HttpResponseMessage GetProduct(int Proid)
        {
            try
            {
                var data = ProductService.GetProduct(Proid);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
      // [Logged]
        [HttpPost]
        [Route("api/products/add")]
        public HttpResponseMessage InsertProduct(ProductDTO product)
        {

            AdminDTO admin = new AdminDTO();
           // DeliveryManDTO addproduct = new DeliveryManDTO();
            string senderEmail = "mollasfuel@gmail.com";
            string senderPassword = "oulcgsufebduckez";
            string recipientEmail = "nadimhasan753990@gmail.com";
            string subject = "Welcome to Our Molla Fuel And Car Service!";
            string body = "<div style=\"font-family: Arial, sans-serif; font-size: 14px; color: #0d0d0d; font-weight: 300;\">"
                  + "<h4>Dear " + admin.Name + ",</h4>"
                  + "<p>Thank you for adding product in Molla Fuel And Car Service. We are thrilled to have you ! " +
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
                var data = ProductService.InsertProduct(product);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
      //  [Logged]
        [HttpPost]
        [Route("api/products/{id}/UpdateProduct")]
        public HttpResponseMessage UpdateProduct(ProductDTO product)
        {
            try
            {
                var data = ProductService.Update(product);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
      //  [Logged]
        [HttpPost]
        [Route("api/products/{id}/DeleteProduct")]
        public HttpResponseMessage DeleteProduct(int product)
        {
            try
            {
                var data = ProductService.DeleteProduct(product);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



        //----     Location --- //
        // [Logged]
        [HttpGet]
        [Route("api/location")]
        public HttpResponseMessage Location()
        {
            try
            {
                var data = WorkerLocationService.GetLocation();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

     //   [Logged]
        [HttpGet]
        [Route("api/location/{id}")]
        public HttpResponseMessage Location(double id)
        {
            try
            {
                var data = WorkerLocationService.GetLocation_wth_ID(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



        //----                   -------------MESSAGE -   ---- //

        // [Logged]
        [HttpPost]
        [Route("api/sendmessage")]

        public HttpResponseMessage PostMassage(MessageDTO message)
        {
            try
            {

                var data = MessageService.InsertMessage(message);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        //   [Logged]
        [HttpGet]
        [Route("api/message")]
        public HttpResponseMessage GetMessage()
        {
            try
            {
                var data = MessageService.GetMSG();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        //  [Logged]

        [HttpGet]
        [Route("api/measage/{id}")]
        public HttpResponseMessage GetMessage_with_id(int id)
        {
           
            try
            {
                var data = MessageService.GetMSG_wth_Id(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


    }
}
