using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleWebApp.Models;
namespace SampleWebApp
{
    public partial class StateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = Application["products"] as List<Product>;
                rpProducts.DataSource = Application["products"] as List<Product>;
                rpProducts.DataBind();
            }
        }
    }
}