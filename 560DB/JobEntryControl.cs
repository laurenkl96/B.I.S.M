using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560DB
{
    public partial class JobEntryControl : UserControl
    {
        public JobEntryControl()
        {
            InitializeComponent();
        }

        private void ux_JobID_Leave(object sender, EventArgs e)
        {
            // call function to check if jobid exists.
            MessageBox.Show("This will show up if the job already exists.");
            // if jobid exists, it will populate the fields and gray out the process and quantity fields.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ux_Complete.Checked == true)
            {
                ux_Complete.ImageIndex = 1;
            }
            else
            {
                ux_Complete.ImageIndex = 0;
            }
        }

        private void ux_InsertUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update the record for Job ID " + ux_JobID.Text + "?", "Confirm Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // call insert function here
                MessageBox.Show("Records Updated.");
            }
            
        }
    }
}
