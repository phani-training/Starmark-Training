using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApp
{
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("api/Validate")]
        public string ValidateEmail(LoginInfo login)
        {
            return "Welcome";
        }
    }
}