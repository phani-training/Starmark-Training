using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        public void Page_Init(object sender, EventArgs e) => Response.Write("Init Event Occured, Page object is initialized");

        public void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Load Event Occured, Page object is loaded");
        }

        public void Page_Render(object sender, EventArgs e) => Response.Write("Rendering of the page is happening. ASP Controls are converted to HTML Controls");
     
    }
}