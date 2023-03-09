using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DataController : ApiController
    {
        [HttpPost]
        [Route("api/Validate")]
        public string ValidateEmail()
        {
            return "Welcome";
        }
    }
}
