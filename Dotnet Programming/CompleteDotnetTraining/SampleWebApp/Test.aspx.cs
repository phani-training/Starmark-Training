using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
   
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rpTest.DataSource = new[] { new Data { Item = "Apples" }, new Data { Item = "Mangoes" }, new Data { Item = "Oranges" } };
            rpTest.DataBind();

        }
    }

    public class Data
    {
        public string Item { get; set; }
        public override string ToString()
        {
            return Item;
        }
    }
}