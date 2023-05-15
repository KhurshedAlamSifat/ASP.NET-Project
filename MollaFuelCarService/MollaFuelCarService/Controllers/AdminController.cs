using BLL.DTOs.AdminDTOs;
using BLL.Services.AdminServices;

using MollaFuelCarService.Authenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;
using System.Web.Services.Description;

namespace MollaFuelCarService.Controllers
{
    public class AdminController : ApiController
    {
        //[Logged]
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
        [Logged]
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
        [Logged]
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

        [Logged]
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
        [Logged]
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
        [Logged]
        [HttpPost]
        [Route("api/products/add")]
        public HttpResponseMessage InsertProduct(ProductDTO product)
        {
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
        [Logged]
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
        [Logged]
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


    }
}
