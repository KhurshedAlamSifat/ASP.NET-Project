using BLL.DTOs.DeliveryManDTOs;
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
        [Route("api/deliverymans")]
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
        [Route("api/deliverymans/{Username}")]
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
        [Route("api/deliverymans/add")]
        public HttpResponseMessage DeliveryMansAdd(DeliveryManDTO deliveryMan)
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
        [Route("api/deliverymans/{Username}/update")]
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
        [Route("api/deliverymans/{Username}/delete")]
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

        [HttpGet]
        [Route("api/deliverymans/count")]
        public HttpResponseMessage DeliveryManCount()
        {
            try
            {
                var data = DeliveryManServices.Get().Count;
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
