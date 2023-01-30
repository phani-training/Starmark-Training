using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class BillingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the cart
            var cart = Session["myCart"] as List<Product>;
            //set the cart to the listview
            lstCart.DataSource = cart;
            lstCart.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var cart = Session["myCart"] as List<Product>;
            var amount = 0.0;
            foreach(var item in cart)
            {
                amount += item.Price * item.Quantity;
            }
            lblMessage.Text = string.Format("An Amount of {0:c} should be paid on Delivery at UR registered Location", amount);
            Session["myCart"] = new List<Product>();
        }
    }
}