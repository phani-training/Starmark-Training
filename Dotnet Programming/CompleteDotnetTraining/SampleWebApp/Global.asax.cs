using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
//Global Application class is one that represents UR Application. It has events for Session and Application state
namespace SampleWebApp
{
    public class Global : System.Web.HttpApplication
    {
        //This event is triggered when the 1st user of the Application hits the server
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["products"] = ProductRepo.AllProducts;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["myCart"] = new List<Product>();
            Session["recentItems"] = new Queue<Product>();
        }
    }
}