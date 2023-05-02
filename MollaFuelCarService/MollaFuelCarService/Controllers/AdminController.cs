using BLL.Services.AdminServices;
using BLL.Services.CustomerServices;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;

namespace MollaFuelCarService.Controllers
{
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

    }
}
