﻿using System;
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
    public partial class OrderPartsControl : UserControl
    {
        public OrderPartsControl()
        {
            InitializeComponent();
            ux_OrderEntryTab.BackColor = Color.Transparent;
            ux_OrderLookupTab.BackColor = Color.Gray;
            ux_PartID.Visible = true;
            ux_PartIDLabel.Visible = true;
            ux_Price.Visible = true;
            ux_PriceLabel.Visible = true;
            ux_Quantity.Visible = true;
            ux_QuantityLabel.Visible = true;
            ux_OrderParts.Visible = true;
            ux_OrderGrid.Visible = false;
            ux_Search.Visible = false;
        }

        private void ux_OrderEntryTab_Click(object sender, EventArgs e)
        {
            ux_OrderEntryTab.BackColor = Color.Transparent;
            ux_OrderLookupTab.BackColor = Color.Gray;
            ux_PartID.Visible = true;
            ux_PartIDLabel.Visible = true;
            ux_Price.Visible = true;
            ux_PriceLabel.Visible = true;
            ux_Quantity.Visible = true;
            ux_QuantityLabel.Visible = true;
            ux_OrderParts.Visible = true;
            ux_OrderGrid.Visible = false;
            ux_Search.Visible = false;
        }

        private void ux_OrderLookupTab_Click(object sender, EventArgs e)
        {
            ux_OrderEntryTab.BackColor = Color.Gray;
            ux_OrderLookupTab.BackColor = Color.Transparent;
            ux_PartID.Visible = false;
            ux_PartIDLabel.Visible = false;
            ux_Price.Visible = false;
            ux_PriceLabel.Visible = false;
            ux_Quantity.Visible = false;
            ux_QuantityLabel.Visible = false;
            ux_OrderParts.Visible = false;
            ux_OrderGrid.Visible = true;
            ux_Search.Visible = true;
        }
    }
}
