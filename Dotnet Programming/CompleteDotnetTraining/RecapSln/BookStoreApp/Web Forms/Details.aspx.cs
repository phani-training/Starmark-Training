using DataAccessLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStoreApp.Web_Forms
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var bookId = Request.QueryString["BookId"];
                var component = BookStoreFactory.GetComponent();
                var table = component.GetAllBooks();
                foreach(DataRow row in table.Rows)
                {
                    if(row[0].ToString() == bookId)
                    {
                        txtBookId.Text = row[0].ToString();
                        txtTitle.Text = row[1].ToString();
                        txtAuthor.Text = row[2].ToString();
                        txtPrice.Text = row[3].ToString();
                        return;
                    }
                }
                
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}