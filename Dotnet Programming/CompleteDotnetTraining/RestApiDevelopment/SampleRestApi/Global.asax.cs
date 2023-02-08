using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
//Get All images and place them in the Images folder
//Create a model called product with appropriate properties
//Create a Repo interface for the Product. 
namespace SampleRestApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            
        }
    }
}
