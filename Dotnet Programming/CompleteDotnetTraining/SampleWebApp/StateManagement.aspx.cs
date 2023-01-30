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
        static Product selectedProduct = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = Application["products"] as List<Product>;
                rpProducts.DataSource = Application["products"] as List<Product>;
                rpProducts.DataBind();
            }
        }

        protected void OnView_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "Details")
            {
                var id = Convert.ToInt32(e.CommandArgument);//Id of the Product U have selected 
                var data = Application["products"] as List<Product>;
                selectedProduct = data.Find((p) => p.ProductId == id);
                txtProductId.Text = selectedProduct.ProductId.ToString();
                txtProductName.Text = selectedProduct.ProductName;
                txtProductCost.Text = selectedProduct.Price.ToString();
                txtQuantity.Text = selectedProduct.Quantity.ToString();

                //Add to the recent list...
                var recentList = Session["recentItems"] as Queue<Product>;
                if (recentList.Count == 5)
                    recentList.Dequeue();
                recentList.Enqueue(selectedProduct);
                Session["recentItems"] = recentList;
                var list = recentList.Reverse();
                lstRecentList.DataSource = list;
                lstRecentList.DataBind();
            }
        }
    }
}