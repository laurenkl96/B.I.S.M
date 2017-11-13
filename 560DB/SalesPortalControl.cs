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
    public partial class SalesPortalControl : UserControl
    {
        public SalesPortalControl()
        {
            InitializeComponent();
            ux_SalesEntryTab.BackColor = Color.Transparent;
            ux_RecieptLookup.BackColor = Color.Gray;
            ux_PartID.Visible = true;
            ux_PartIDLabel.Visible = true;
            ux_Price.Visible = true;
            ux_PriceLabel.Visible = true;
            ux_Quantity.Visible = true;
            ux_QuantityLabel.Visible = true;
            ux_InsertUpdate.Visible = true;
            ux_RecieptGrid.Visible = false;
            ux_Search.Visible = false;
        }

        private void ux_SalesEntryTab_Click(object sender, EventArgs e)
        {
            ux_SalesEntryTab.BackColor = Color.Transparent;
            ux_RecieptLookup.BackColor = Color.Gray;
            ux_PartID.Visible = true;
            ux_PartIDLabel.Visible = true;
            ux_Price.Visible = true;
            ux_PriceLabel.Visible = true;
            ux_Quantity.Visible = true;
            ux_QuantityLabel.Visible = true;
            ux_InsertUpdate.Visible = true;
            ux_RecieptGrid.Visible = false;
            ux_Search.Visible = false;
        }

        private void ux_RecieptLookup_Click(object sender, EventArgs e)
        {
            ux_SalesEntryTab.BackColor = Color.Gray;
            ux_RecieptLookup.BackColor = Color.Transparent;
            ux_PartID.Visible = false;
            ux_PartIDLabel.Visible = false;
            ux_Price.Visible = false;
            ux_PriceLabel.Visible = false;
            ux_Quantity.Visible = false;
            ux_QuantityLabel.Visible = false;
            ux_RecieptGrid.Visible = true;
            ux_Search.Visible = true;
            ux_InsertUpdate.Visible = false;
        }
    }
}
