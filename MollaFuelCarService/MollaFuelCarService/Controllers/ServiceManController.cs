using BLL.Services.CustomerServices;
using BLL.Services.ServiceManServices;
using BLL.Services.ServiceManHistoryServices;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MollaFuelCarService.Controllers
{
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
        public HttpResponseMessage ServiceMansAdd(ServiceMan ServiceMan)
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
        public HttpResponseMessage ServiceMansUpdate(ServiceMan Username)
        {
            try
            {
                var data = ServiceManService.Update(Username);
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
                var data = ServiceManOrderlistService.Delete(OrderId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
         [HttpGet]
        [Route("api/servicehistory")]
        public HttpResponseMessage ServiceManHistorys()
        {
            try
            {
                var data = ServiceManHistoryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/servicehistory/{Id}")]
        public HttpResponseMessage ServiceManHistorys(int Id)
        {
            try
            {
                var data = ServiceManHistoryService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/servicehistory/{Id}/delete")]
        public HttpResponseMessage ServiceManHistorysDelete(int Id)
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

    }
}
