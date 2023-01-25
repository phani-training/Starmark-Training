using System;
using System.Linq;
using System.Web.UI.WebControls;
using SampleWebApp.Models;
namespace SampleWebApp
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = ProductRepo.AllProducts;
                foreach (var item in data)
                lstProducts.Items.Add(new ListItem
                {
                    Text = item.ProductName,
                    Value = item.ProductId.ToString()
                });
            }
        }

        protected void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            var id = int.Parse(lstProducts.SelectedValue);
            var selected = ProductRepo.AllProducts.FirstOrDefault((p) => p.ProductId == id);
            txtId.Text = selected.ProductId.ToString();
            txtName.Text = selected.ProductName;
            txtPrice.Text = selected.Price.ToString();
            imgPic.ImageUrl = selected.Image;
            
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Image = imgPic.ImageUrl,
                Price = int.Parse(txtPrice.Text),
                ProductId = int.Parse(txtId.Text),
                ProductName = txtName.Text,
                Quantity = int.Parse(dpQuantity.Text)
            };
            ProductRepo.UpdateProduct(product);
            Response.Redirect("Products.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ProductRepo.DeleteProduct(int.Parse(txtId.Text));
            Response.Redirect("Products.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Image = imgPic.ImageUrl,
                Price = int.Parse(txtPrice.Text),
                ProductId = int.Parse(txtId.Text),
                ProductName = txtName.Text,
                Quantity = int.Parse(dpQuantity.Text)
            };
            ProductRepo.AddNewProduct(product);
            Response.Redirect("Products.aspx");
        }
    }
}