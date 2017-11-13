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
    public partial class PartEntryControl : UserControl
    {
        public PartEntryControl()
        {
            InitializeComponent();
        }

        private void ux_PartID_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("This will show if the user types in a valid partID");
        }

        private void ux_InsertUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update the record for Job ID " + ux_PartID.Text + "?", "Confirm Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // call insert function here

                // display results in following box.
                MessageBox.Show("Records Updated.");
            }
        }
    }
}
