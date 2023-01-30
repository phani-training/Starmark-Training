using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
 * There are different ways to save the state(Data) of the page. 
 * There is Clientside State Management and Serverside State Management
 * Client Side statemanagement:
 * Querystring: Text based data shared thru the URL of the Page. Users can see and change the values of the data as it is shared thru URL. Querystring can share only text based data. Some urls restrict the length of the URL to be not more than 255 charecters. 
 * Cookies: Small Text based content that is saved into the Client machines. They are text files, they are harmless. All cookies in ASP.NET are represented as objects of a class called System.Web.HttpCookie.  Clients can remove the cookies, so reliable data cannot be stored as Cookies. Clients can disable the cookies.
 * ViewState: Stores the info within the page, used to refer the value in the same page. 
 */
namespace SampleWebApp
{
    public partial class InputPage : System.Web.UI.Page
    {
        static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            count++;
        }
        //Called when the user clicks the button....
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            /***************************QueryString****************************
            string url = $"RecipiantPage.aspx?name={txtName.Text}&email={txtEmail.Text}&contact={txtContact.Text}";
            Response.Redirect(url);
            ***************************Cookies********************
            HttpCookie cookie = new HttpCookie("MyUserInfo");
            cookie.Values.Add("name", txtName.Text);
            cookie.Values.Add("email", txtEmail.Text);
            cookie.Values.Add("phone", txtContact.Text);
            Response.Cookies.Add(cookie);
            Response.Redirect("RecipiantPage.aspx");
            **********************ViewState**************************/
            ViewState["Hits"] = count;
            Response.Write("The Hits: " + ViewState["Hits"].ToString());
        }
    }
}