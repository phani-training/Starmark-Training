using DataAccessLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var address = txtAddress.Text;
            var salary = int.Parse(txtSalary.Text);
            var phone = long.Parse(txtPhone.Text);
            var component = DataFactory.GetComponent();
            try
            {
                component.RegisterNewEmployee(name, address, salary, phone);
                MessageBox.Show(Messages.INSERT_EMPLOYEE_SUCCESS);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Messages.INSERT_EMPLOYEE_FAILURE);
                Debug.WriteLine(ex.Message);
            }
        }

        private void DataEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            SampleWinApp.ParentForm.dEntryfrm = null;
            
        }
    }
}
