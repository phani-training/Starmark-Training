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
                getProduct(id);

                //Add to the recent list...
                addToRecentList();
            }
        }

        private void addToRecentList()
        {
            //Get the Current list
            var recentList = Session["recentItems"] as Queue<Product>;
            //Count should be more than 5...
            if (recentList.Count == 5)
                recentList.Dequeue();
            //Add the newly selected Item into the recentList
            recentList.Enqueue(selectedProduct);
            //Set it back to the Session State
            Session["recentItems"] = recentList;
            //Reverse the queue for getting the latest added to the top
            var list = recentList.Reverse();
            //set the list to the lstRecentList Control
            lstRecentList.DataSource = list;
            lstRecentList.DataBind();
        }

        private void getProduct(int id)
        {
            var data = Application["products"] as List<Product>;
            selectedProduct = data.Find((p) => p.ProductId == id);
            txtProductId.Text = selectedProduct.ProductId.ToString();
            txtProductName.Text = selectedProduct.ProductName;
            txtProductCost.Text = selectedProduct.Price.ToString();
            txtQuantity.Text = selectedProduct.Quantity.ToString();
        }
    }
}