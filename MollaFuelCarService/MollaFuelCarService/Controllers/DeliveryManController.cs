using BLL.Services.CustomerServices;
using BLL.Services.DeliveryManServices;
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
    public class DeliveryManController : ApiController
    {
        [HttpGet]
        [Route("api/DeliveryMans")]
        public HttpResponseMessage DeliveryMans()
        {
            try
            {
                var data = DeliveryManServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        //----------------------

        //[Logged]
        [HttpGet]
        [Route("api/DeliveryMans/{Username}")]
        public HttpResponseMessage DeliveryMans(string Username)
        {
            try
            {
                var data = DeliveryManServices.Get(Username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        //--------------------------
        [HttpPost]
        [Route("api/DeliveryMans/add")]
        public HttpResponseMessage DeliveryMansAdd(DeliveryMan deliveryMan)
        {
            try
            {
                var data = DeliveryManServices.Insert(deliveryMan);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        //----------------------------
        [HttpPost]
        [Route("api/DeliveryMans/{Username}/update")]
        public HttpResponseMessage DeliveryMansUpdate(DeliveryMan deliveryMan)
        {
            try
            {
                var data = DeliveryManServices.Update(deliveryMan);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        //---------------------------------
        [HttpPost]
        [Route("api/DeliveryMans/{Username}/delete")]
        public HttpResponseMessage DeliveryMansDelete(string Username)
        {
            try
            {
                var data = DeliveryManServices.Delete(Username);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
