using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _560DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ux_ActiveBar.Location = ux_Home.Location;
            hide_controls();
            homeControl1.Enabled = true;
            homeControl1.Visible = true;
            homeControl1.BringToFront();
            string connstr = "server=mysql.cis.ksu.edu;user=jordanmartin;database=jordanmartin;port=3306;password=insecurepassword";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                homeControl1.Update("calbenne", "calbenne");
            }
            catch (Exception e)
            {
                homeControl1.Update("Error connecting to Database", "No user");
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ux_Home_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = ux_Home.Location;
            hide_controls();
            homeControl1.Enabled = true;
            homeControl1.Visible = true;
            homeControl1.BringToFront();

        }

        private void ux_JobSearch_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = ux_JobSearch.Location;
            hide_controls();
            jobSearchControl1.Enabled = true;
            jobSearchControl1.Visible = true;
            jobSearchControl1.BringToFront();
        }

        private void ux_PartSearch_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = ux_PartSearch.Location;
            hide_controls();
        }

        private void uxJobEntry_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = uxJobEntry.Location;
            hide_controls();
        }

        private void ux_PartEntry_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = ux_PartEntry.Location;
            hide_controls();
        }

        private void ux_SalesPortal_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = ux_SalesPortal.Location;
            hide_controls();
        }

        private void ux_OrderParts_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = ux_OrderParts.Location;
            hide_controls();
        }

        private void ux_Analyze_Click(object sender, EventArgs e)
        {
            ux_ActiveBar.Location = ux_Analyze.Location;
            hide_controls();
        }

        private void hide_controls()
        {
            homeControl1.Enabled = false;
            homeControl1.Visible = false;
            jobSearchControl1.Enabled = false;
            jobSearchControl1.Visible = false;
        }
    }
}
