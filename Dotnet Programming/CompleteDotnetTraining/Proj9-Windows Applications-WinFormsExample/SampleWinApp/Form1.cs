using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Testing my Win App", "Title of the msgBox", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(res == DialogResult.Yes)
                MessageBox.Show("Yes was pressed");
            else
                MessageBox.Show("No was pressed");
        }

        private void OnRadio_Clicked(object sender, EventArgs e)
        {
            var btn = sender as RadioButton;
            var text = btn.Text;
            var v1 = double.Parse(txtFirstValue.Text);
            var v2 = double.Parse(txtSecondValue.Text);
            switch (text)
            {
                case "Add":
                    MessageBox.Show("The Added value: " + (v1 + v2));
                    return;
                case "Subtract":
                    MessageBox.Show("The Subtracted value: " + (v1 - v2));
                    return;
                case "Multiply":
                    MessageBox.Show("The Subtracted value: " + (v1 - v2));
                    return;
                case "Divide":
                    MessageBox.Show("The Subtracted value: " + (v1 - v2));
                    return;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SampleWinApp.ParentForm.calcForm = null;
        }
    }
    //Data Entry form: Take inputs from the User and store it into a table in the database. U should perform the appropriate validations. 
}
