using DataAccessLib;
using System;
using System.Web.UI;

namespace SampleWebApp
{
    public partial class ProductApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var component = ProductFactory.GetComponent();
                lstProducts.DataSource = component.GetAllProducts();
                lstProducts.DataTextField = "ProductName";
                lstProducts.DataValueField = "ProductId";
                lstProducts.DataBind();
            }
        }

        protected void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var component = ProductFactory.GetComponent();
            var pId = int.Parse(lstProducts.SelectedItem.Value);
            var selectedProduct = component.GetAllProducts().Find((p) => p.ProductId == pId);
            populateData(selectedProduct);
        }

        private void populateData(Product product)
        {
            txtId.Text = product.ProductId.ToString();
            txtName.Text = product.ProductName;
            txtPrice.Text = product.ProductPrice.ToString();
            imgPic.ImageUrl = product.ProductImage;
            dpQuantity.Text = product.Quantity.ToString();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var component = ProductFactory.GetComponent();
            var product = new Product
            {
                ProductImage = uploadFile(),
                ProductPrice = int.Parse(txtPrice.Text),
                ProductId = int.Parse(txtId.Text),
                ProductName = txtName.Text,
                Quantity = int.Parse(dpQuantity.Text)
            };
            component.UpdateProduct(product);
            Response.Redirect("ProductApp.aspx");

        }
        private string uploadFile()
        {
            string imgName = string.Empty;
            string imgPath = string.Empty;
            if (fileUploader.PostedFile.FileName != String.Empty)
            {
                //get the file name of the posted image           
                imgName = fileUploader.PostedFile.FileName;
                //sets the image path           
                imgPath = @".\Images\" + imgName;
                //then save it to the Folder  
                fileUploader.SaveAs(Server.MapPath(imgPath));
            }
            return imgPath;
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {

            var imgPath = uploadFile();

            var product = new Product
            {
                ProductImage = imgPath,
                ProductPrice = int.Parse(txtPrice.Text),
                ProductName = txtName.Text,
                Quantity = int.Parse(dpQuantity.Text)
            };
            var component = ProductFactory.GetComponent();
            component.AddProduct(product);
            Response.Redirect("ProductApp.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var msg = "Product deleted Successfully";
            var alert = $"alert({msg})";
            var component = ProductFactory.GetComponent();
            component.DeleteProduct(int.Parse(txtId.Text));
            Page.ClientScript.RegisterClientScriptBlock(typeof(ProductApp), "Alert", alert,true);
            Response.Redirect("ProductApp.aspx");
        }
    }
}