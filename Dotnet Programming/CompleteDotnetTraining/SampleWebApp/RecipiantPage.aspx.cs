using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class RecipiantPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //querystringExample();
            cookiesExample();
        }

        private void cookiesExample()
        {
            var cookie = Request.Cookies["MyUserInfo"];
            if(cookie == null)
            {
                lblMessage.Text = "This page does not contain any information. Please visit the InputPage first";
            }
            else
            {
                string msg = $"The Name entered is {cookie.Values["name"]}<br/>The Email Address is {cookie.Values["email"]}<br/>The Contact No entered is {cookie.Values["phone"]}";
                lblMessage.Text = msg;
            }
        }

        private void querystringExample()
        {
            if (Request.QueryString.Count == 0)
            {
                lblMessage.Text = "This page does not contain any information. Please visit the InputPage first";
            }
            else
            {
                try
                {
                    string msg = $"The Name entered is {Request.QueryString["name"]}<br/>The Email Address is {Request.QueryString["email"]}<br/>The Contact No entered is {Request.QueryString["contact"]}";
                    lblMessage.Text = msg;
                }
                catch (NullReferenceException)
                {
                    lblMessage.Text = "Querystring keys are not correct";
                }
                catch (FormatException)
                {
                    lblMessage.Text = "String wasnt populated properly";
                }

            }
        }
    }
}