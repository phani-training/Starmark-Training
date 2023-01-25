using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if ((args.Value == "Trainer") || (args.Value == "Trainee"))
                args.IsValid = true;
            else
                args.IsValid = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string content = $"The Name: {txtName.Text}<br/>The Email Address: {txtEmail.Text} with an Experience of over {txtExperience.Text} years";
                lblInfo.Text = content;
            }
            else
            {
                lblInfo.Text = String.Empty;
            }
        }
    }
}