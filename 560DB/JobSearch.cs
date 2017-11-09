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
    public partial class JobSearchControl : UserControl
    {
        public JobSearchControl()
        {
            InitializeComponent();
            ux_ProcessSearch.BackColor = Color.Gray;
            ux_DateSearch.BackColor = Color.Gray;
            ux_JobIDSearch.BackColor = Color.Transparent;
            ux_endDate.Visible = false;
            ux_EndLabel.Visible = false;
            ux_StartDate.Visible = false;
            ux_StartLabel.Visible = false;
            ux_SearchLabel.Visible = true;
            ux_SearchText.Visible = true;
            ux_SearchLabel.Text = "Job ID:";
        }

        private void ux_JobIDSearch_Click(object sender, EventArgs e)
        {
            ux_ProcessSearch.BackColor = Color.Gray;
            ux_DateSearch.BackColor = Color.Gray;
            ux_JobIDSearch.BackColor = Color.Transparent;
            ux_endDate.Visible = false;
            ux_EndLabel.Visible = false;
            ux_StartDate.Visible = false;
            ux_StartLabel.Visible = false;
            ux_SearchLabel.Visible = true;
            ux_SearchText.Visible = true;
            ux_SearchLabel.Text = "Job ID:";
        }

        private void ux_ProcessSearch_Click(object sender, EventArgs e)
        {
            ux_DateSearch.BackColor = Color.Gray;
            ux_JobIDSearch.BackColor = Color.Gray;
            ux_ProcessSearch.BackColor = Color.Transparent;
            ux_endDate.Visible = false;
            ux_EndLabel.Visible = false;
            ux_StartDate.Visible = false;
            ux_StartLabel.Visible = false;
            ux_SearchLabel.Visible = true;
            ux_SearchText.Visible = true;
            ux_SearchLabel.Text = "Process Name: ";
        }

        private void ux_DateSearch_Click(object sender, EventArgs e)
        {
            ux_DateSearch.BackColor = Color.Transparent;
            ux_JobIDSearch.BackColor = Color.Gray;
            ux_ProcessSearch.BackColor = Color.Gray;
            ux_SearchText.Visible = false;
            ux_SearchLabel.Visible = false;
            ux_endDate.Visible = true;
            ux_EndLabel.Visible = true;
            ux_StartDate.Visible = true;
            ux_StartLabel.Visible = true;
        }
    }
}
