using DataAccessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStoreApp.Web_Forms
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var author = txtAuthor.Text;
            var price = int.Parse(txtPrice.Text);
            var component = BookStoreFactory.GetComponent();
            component.AddNewBook(title, author, price);
            Response.Redirect("~/Web Forms/BookStoreApp.aspx");
        }
    }
}