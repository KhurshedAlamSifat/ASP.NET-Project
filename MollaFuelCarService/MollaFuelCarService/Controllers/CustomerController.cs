using BLL.DTOs.CustomerDTOs;
using BLL.Services.CustomerServices;
using DAL.Models;
using MollaFuelCarService.Authenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MollaFuelCarService.Controllers
{

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
        public HttpResponseMessage CustomersAdd(Customer customer)
        {
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
        public HttpResponseMessage CustomersUpdate(Customer username)
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

    }
}
