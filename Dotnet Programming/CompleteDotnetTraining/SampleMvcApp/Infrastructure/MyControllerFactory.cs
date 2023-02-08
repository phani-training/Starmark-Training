using SampleMvcApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace SampleMvcApp.Infrastructure
{
    public class MyControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName == "Cars")
            {
                return new CarsController();
            }
            else if (controllerName == "FirstExample")
                return new FirstExampleController();
            else
                throw new Exception("Controller is not supported with us!!!");
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            disposable.Dispose();//Deleting the object...
        }
    }
}