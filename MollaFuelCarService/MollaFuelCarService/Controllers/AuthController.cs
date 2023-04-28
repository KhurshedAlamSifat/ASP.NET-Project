using BLL.Services.CustomerServices;
using MollaFuelCarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace MollaFuelCarService.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel login)
        {
            try
            {
                var res = AuthenticateService.Authenticate(login.Username, login.Password);
                if(res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,res);
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new  { Message = "User not Found!" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
