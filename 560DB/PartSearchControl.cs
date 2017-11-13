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
    public partial class PartSearchControl : UserControl
    {
        public int partorname = 0;

        public PartSearchControl()
        {
            InitializeComponent();
            ux_PartSearch.BackColor = Color.Transparent;
            ux_NameSearch.BackColor = Color.Gray;
        }

        private void ux_PartSearch_Click(object sender, EventArgs e)
        {
            ux_PartSearch.BackColor = Color.Transparent;
            ux_NameSearch.BackColor = Color.Gray;
            partorname = 0;
        }

        private void ux_NameSearch_Click(object sender, EventArgs e)
        {
            ux_NameSearch.BackColor = Color.Transparent;
            ux_PartSearch.BackColor = Color.Gray;
            partorname = 1;
        }
    }
}
