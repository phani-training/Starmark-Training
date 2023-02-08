using LoginApp.DataComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
           if(Session["CurrentUser"] != null)
            {
                var cstDetails = Session["CurrentUser"] as CustomerTable;
                return $"<h1>Home Page</h1><hr/><p>Welcome to User {cstDetails.CustomerName}"; 
            }
            else
            {
                return $"<h1>Home Page</h1><hr/><p>Welcome to Anonymous User";
            }
        }
    }
}