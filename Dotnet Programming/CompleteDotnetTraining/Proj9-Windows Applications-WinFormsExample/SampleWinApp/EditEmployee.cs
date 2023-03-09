using DataAccessLib;
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
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        public EditEmployee(int id) : this()
        {
            var component = DataFactory.GetComponent();
            var found = component.FindEmployee(id);
            DataRow row = found.Rows[0];//Always the first row...
            txtId.Text = row[0].ToString();
            txtName.Text = row[1].ToString();
            txtAddress.Text = row[2].ToString();
            txtSalary.Text = row[3].ToString();
            txtPhone.Text = row[4].ToString();
        }
    }
}
