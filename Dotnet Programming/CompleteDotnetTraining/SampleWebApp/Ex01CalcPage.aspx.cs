using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Ex01CalcPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            var v1 = double.Parse(txtFirstNo.Text);
            var v2 = double.Parse(txtSecondNo.Text);
            var operation = dpList.SelectedValue;
            var result = getResult(v1, v2, operation);
            lblDisplay.Text = "The Result: " + result;
        }

        private double getResult(double v1, double v2, string operation)
        {
            switch (operation)
            {
                case "Add": return v1 + v2;
                case "Subtract": return v1 - v2;
                case "Multiply": return v1 * v2;
                case "Divide": return v1 / v2;
                default:
                    break;
            }
            return 0;
        }
    }
}