using BLL.Services.CustomerServices;
using BLL.Services.ServiceManServices;
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

    }
}
