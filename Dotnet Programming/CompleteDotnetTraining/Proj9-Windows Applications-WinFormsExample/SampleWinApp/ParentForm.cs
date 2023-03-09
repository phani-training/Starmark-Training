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
    public partial class ParentForm : Form
    {
        public static DataEntry dEntryfrm;
        public static Form1 calcForm;
        public static ViewEmployees viewForm;
        public ParentForm()
        {
            InitializeComponent();
        }

        
        private void calcProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calcForm == null)
            {
                calcForm = new Form1();
                calcForm.MdiParent = this;
            }
            calcForm.Show();
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dEntryfrm == null)
            {
                dEntryfrm = new DataEntry();
                dEntryfrm.MdiParent = this;
            }
            dEntryfrm.Show();
        }

        private void viewAllEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(viewForm == null)
            {
                viewForm = new ViewEmployees();
                viewForm.MdiParent = this;
            }
            viewForm.Show();
        }
    }
}
