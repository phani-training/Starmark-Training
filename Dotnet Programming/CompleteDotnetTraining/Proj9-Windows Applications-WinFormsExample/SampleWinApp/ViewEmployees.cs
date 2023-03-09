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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private async void ViewEmployees_Load(object sender, EventArgs e)
        {
            //get the employees and bind to the grid.
            IDataComponent component = DataFactory.GetComponent();
            grdEmployees.DataSource =  await component.GetAllEmployees();
        }

        private void ViewEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            SampleWinApp.ParentForm.viewForm = null;
        }

        private void grdEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdEmployees_SelectionChanged(object sender, EventArgs e)
        {
           if(grdEmployees.SelectedRows.Count != 0)
            {
                DataGridViewRow row = grdEmployees.SelectedRows[0];
                int id = (int)row.Cells[0].Value;
                EditEmployee frm = new EditEmployee(id);
                frm.ShowDialog(this);
            }

        }

      
    }
}
