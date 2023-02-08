using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleMvcApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "MathOperations",
                url: "{controller}/{action}/{v1}/{v2}",
                defaults: new { controller = "FirstExample", action = "GetNumber" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Calc", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
