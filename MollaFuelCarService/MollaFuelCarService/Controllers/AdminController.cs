﻿using BLL.Services.AdminServices;

using DAL.Models;
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
        [Route("api/admin/{id}")]
        public HttpResponseMessage Admin(int id)
        {
            try
            {
                var data = AdminService.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [Logged]
        [HttpPost]
        [Route("api/admin/add")]
        public HttpResponseMessage ADD_Admin(Admin admin)
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
        [Route("api/admin/{id}/update")]
        public HttpResponseMessage Update_Admin(Admin admin)
        {
            try
            {
                var data = AdminService.Update(admin);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [Logged]
        [HttpPost]
        [Route("api/admin/{id}/delete")]
        public HttpResponseMessage Delete_Admin(int id)
        {
            try
            {
                var data = AdminService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [Logged]
        [HttpGet]
        [Route("api/admin/product")]
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
        [Route("api/product/{id}")]
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
        [Route("api/product/add")]
        public HttpResponseMessage InsertProduct(Product product)
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
        [Route("api/product/{id}/UpdateProduct")]
        public HttpResponseMessage UpdateProduct(Product product)
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
        [Route("api/product/{id}/DeleteProduct")]
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
