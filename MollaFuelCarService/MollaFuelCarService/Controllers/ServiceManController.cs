using BLL.Services.CustomerServices;
using BLL.Services.ServiceManServices;
using BLL.Services.ServiceManHistoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs.ServiceManDTOs;
using BLL.Services.DeliveryManServices;
using MollaFuelCarService.Authenticate;
using System.Web.Http.Cors;
using System.Net.Mail;

namespace MollaFuelCarService.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ServiceManController : ApiController
    {
        [HttpGet]
        [Route("api/serviceman")]
        public HttpResponseMessage ServiceMans()
        {
            try
            {
                var data = ServiceManService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [Logged]
        [HttpGet]
        [Route("api/serviceman/{Username}")]
        public HttpResponseMessage ServiceMans(string Username)
        {
            try
            {
                var data = ServiceManService.Get(Username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/serviceman/add")]
        public HttpResponseMessage ServiceMansAdd(ServiceManDTO ServiceMan)
        {
            try
            {
                var data = ServiceManService.Insert(ServiceMan);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/serviceman/{username}/update")]
        public HttpResponseMessage ServiceMansUpdate(ServiceManDTO Username)
        {
            try
            {
                var data = ServiceManService.Updated(Username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/serviceman/{Username}/delete")]
        public HttpResponseMessage ServicemansDelete(string Username)
        {
            try
            {
                var data = ServiceManService.Delete(Username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/orderlist")]
        public HttpResponseMessage Orderlist()
        {
            try
            {
                var data = ServiceManOrderlistService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/orderlist/{OrderId}")]
        public HttpResponseMessage Orderlist(int OrderId)
        {
            try
            {
                var data = ServiceManOrderlistService.Get(OrderId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/orderlist/{OrderId}/delete")]
        public HttpResponseMessage OrderIdDelete(int OrderId)
        {
            
            try
            {
                var data = ServiceManHistoryService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/serviceman/count")]
        public HttpResponseMessage ServiceManCount()
        {
            try
            {
                var data = ServiceManService.Get().Count;
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

    }
}
