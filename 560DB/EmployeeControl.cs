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
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
            ux_NameSearch.BackColor = Color.Transparent;
            ux_JobSearch.BackColor = Color.Transparent;
            ux_SearchLabel.Text = "Name:";
        }

        private void ux_NameSearch_Click(object sender, EventArgs e)
        {
            ux_NameSearch.BackColor = Color.Transparent;
            ux_JobSearch.BackColor = Color.Transparent;
            ux_SearchLabel.Text = "Name:";
        }

        private void ux_JobSearch_Click(object sender, EventArgs e)
        {
            ux_NameSearch.BackColor = Color.Gray;
            ux_JobSearch.BackColor = Color.Transparent;
            ux_SearchLabel.Text = "Title:";
        }
    }
}
