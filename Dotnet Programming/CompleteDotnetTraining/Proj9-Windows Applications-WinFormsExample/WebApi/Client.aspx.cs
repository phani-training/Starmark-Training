using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApi
{
    public partial class Client : System.Web.UI.Page
    {
        [WebMethod(EnableSession =true)]
        public string test()
        {
            return "Test";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}