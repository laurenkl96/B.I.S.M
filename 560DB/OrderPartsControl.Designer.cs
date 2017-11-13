namespace _560DB
{
    partial class OrderPartsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ux_OrderLookupTab = new System.Windows.Forms.Button();
            this.ux_OrderEntryTab = new System.Windows.Forms.Button();
            this.ux_Search = new System.Windows.Forms.Button();
            this.ux_Price = new System.Windows.Forms.NumericUpDown();
            this.ux_Quantity = new System.Windows.Forms.NumericUpDown();
            this.ux_OrderParts = new System.Windows.Forms.Button();
            this.ux_PartID = new System.Windows.Forms.TextBox();
            this.ux_SupplierName = new System.Windows.Forms.TextBox();
            this.ux_PriceLabel = new System.Windows.Forms.Label();
            this.ux_QuantityLabel = new System.Windows.Forms.Label();
            this.ux_PartIDLabel = new System.Windows.Forms.Label();
            this.ux_SupplierNameLabel = new System.Windows.Forms.Label();
            this.ux_OrderGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_OrderLookupTab
            // 
            this.ux_OrderLookupTab.FlatAppearance.BorderSize = 0;
            this.ux_OrderLookupTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ux_OrderLookupTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_OrderLookupTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_OrderLookupTab.Location = new System.Drawing.Point(375, 0);
            this.ux_OrderLookupTab.Name = "ux_OrderLookupTab";
            this.ux_OrderLookupTab.Size = new System.Drawing.Size(376, 40);
            this.ux_OrderLookupTab.TabIndex = 27;
            this.ux_OrderLookupTab.Text = "Order Lookup";
            this.ux_OrderLookupTab.UseVisualStyleBackColor = true;
            this.ux_OrderLookupTab.Click += new System.EventHandler(this.ux_OrderLookupTab_Click);
            // 
            // ux_OrderEntryTab
            // 
            this.ux_OrderEntryTab.FlatAppearance.BorderSize = 0;
            this.ux_OrderEntryTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ux_OrderEntryTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_OrderEntryTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_OrderEntryTab.Location = new System.Drawing.Point(0, 0);
            this.ux_OrderEntryTab.Name = "ux_OrderEntryTab";
            this.ux_OrderEntryTab.Size = new System.Drawing.Size(375, 40);
            this.ux_OrderEntryTab.TabIndex = 26;
            this.ux_OrderEntryTab.Text = "Order Entry";
            this.ux_OrderEntryTab.UseVisualStyleBackColor = true;
            this.ux_OrderEntryTab.Click += new System.EventHandler(this.ux_OrderEntryTab_Click);
            // 
            // ux_Search
            // 
            this.ux_Search.BackColor = System.Drawing.Color.Gray;
            this.ux_Search.FlatAppearance.BorderSize = 0;
            this.ux_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ux_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Search.Location = new System.Drawing.Point(614, 95);
            this.ux_Search.Name = "ux_Search";
            this.ux_Search.Size = new System.Drawing.Size(121, 25);
            this.ux_Search.TabIndex = 37;
            this.ux_Search.Text = "Search";
            this.ux_Search.UseVisualStyleBackColor = false;
            // 
            // ux_Price
            // 
            this.ux_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Price.Location = new System.Drawing.Point(370, 289);
            this.ux_Price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ux_Price.Name = "ux_Price";
            this.ux_Price.Size = new System.Drawing.Size(120, 25);
            this.ux_Price.TabIndex = 36;
            // 
            // ux_Quantity
            // 
            this.ux_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Quantity.Location = new System.Drawing.Point(370, 223);
            this.ux_Quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ux_Quantity.Name = "ux_Quantity";
            this.ux_Quantity.Size = new System.Drawing.Size(120, 25);
            this.ux_Quantity.TabIndex = 35;
            // 
            // ux_OrderParts
            // 
            this.ux_OrderParts.BackColor = System.Drawing.Color.Gray;
            this.ux_OrderParts.FlatAppearance.BorderSize = 0;
            this.ux_OrderParts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ux_OrderParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_OrderParts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_OrderParts.Location = new System.Drawing.Point(266, 420);
            this.ux_OrderParts.Name = "ux_OrderParts";
            this.ux_OrderParts.Size = new System.Drawing.Size(218, 49);
            this.ux_OrderParts.TabIndex = 34;
            this.ux_OrderParts.Text = "Order Parts";
            this.ux_OrderParts.UseVisualStyleBackColor = false;
            // 
            // ux_PartID
            // 
            this.ux_PartID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartID.Location = new System.Drawing.Point(370, 154);
            this.ux_PartID.Name = "ux_PartID";
            this.ux_PartID.Size = new System.Drawing.Size(173, 25);
            this.ux_PartID.TabIndex = 33;
            // 
            // ux_SupplierName
            // 
            this.ux_SupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_SupplierName.Location = new System.Drawing.Point(370, 95);
            this.ux_SupplierName.Name = "ux_SupplierName";
            this.ux_SupplierName.Size = new System.Drawing.Size(238, 25);
            this.ux_SupplierName.TabIndex = 32;
            // 
            // ux_PriceLabel
            // 
            this.ux_PriceLabel.AutoSize = true;
            this.ux_PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PriceLabel.Location = new System.Drawing.Point(248, 293);
            this.ux_PriceLabel.Name = "ux_PriceLabel";
            this.ux_PriceLabel.Size = new System.Drawing.Size(73, 21);
            this.ux_PriceLabel.TabIndex = 31;
            this.ux_PriceLabel.Text = "Price Per:";
            // 
            // ux_QuantityLabel
            // 
            this.ux_QuantityLabel.AutoSize = true;
            this.ux_QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_QuantityLabel.Location = new System.Drawing.Point(248, 227);
            this.ux_QuantityLabel.Name = "ux_QuantityLabel";
            this.ux_QuantityLabel.Size = new System.Drawing.Size(77, 21);
            this.ux_QuantityLabel.TabIndex = 30;
            this.ux_QuantityLabel.Text = " Quantity:";
            // 
            // ux_PartIDLabel
            // 
            this.ux_PartIDLabel.AutoSize = true;
            this.ux_PartIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartIDLabel.Location = new System.Drawing.Point(266, 158);
            this.ux_PartIDLabel.Name = "ux_PartIDLabel";
            this.ux_PartIDLabel.Size = new System.Drawing.Size(59, 21);
            this.ux_PartIDLabel.TabIndex = 29;
            this.ux_PartIDLabel.Text = "Part ID:";
            // 
            // ux_SupplierNameLabel
            // 
            this.ux_SupplierNameLabel.AutoSize = true;
            this.ux_SupplierNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_SupplierNameLabel.Location = new System.Drawing.Point(202, 95);
            this.ux_SupplierNameLabel.Name = "ux_SupplierNameLabel";
            this.ux_SupplierNameLabel.Size = new System.Drawing.Size(117, 21);
            this.ux_SupplierNameLabel.TabIndex = 28;
            this.ux_SupplierNameLabel.Text = "Supplier Name:";
            // 
            // ux_OrderGrid
            // 
            this.ux_OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_OrderGrid.Location = new System.Drawing.Point(15, 131);
            this.ux_OrderGrid.Name = "ux_OrderGrid";
            this.ux_OrderGrid.Size = new System.Drawing.Size(719, 365);
            this.ux_OrderGrid.TabIndex = 38;
            // 
            // OrderPartsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ux_Search);
            this.Controls.Add(this.ux_Price);
            this.Controls.Add(this.ux_Quantity);
            this.Controls.Add(this.ux_OrderParts);
            this.Controls.Add(this.ux_PartID);
            this.Controls.Add(this.ux_SupplierName);
            this.Controls.Add(this.ux_PriceLabel);
            this.Controls.Add(this.ux_QuantityLabel);
            this.Controls.Add(this.ux_PartIDLabel);
            this.Controls.Add(this.ux_SupplierNameLabel);
            this.Controls.Add(this.ux_OrderGrid);
            this.Controls.Add(this.ux_OrderLookupTab);
            this.Controls.Add(this.ux_OrderEntryTab);
            this.Name = "OrderPartsControl";
            this.Size = new System.Drawing.Size(751, 535);
            ((System.ComponentModel.ISupportInitialize)(this.ux_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_OrderLookupTab;
        private System.Windows.Forms.Button ux_OrderEntryTab;
        private System.Windows.Forms.Button ux_Search;
        private System.Windows.Forms.NumericUpDown ux_Price;
        private System.Windows.Forms.NumericUpDown ux_Quantity;
        private System.Windows.Forms.Button ux_OrderParts;
        private System.Windows.Forms.TextBox ux_PartID;
        private System.Windows.Forms.TextBox ux_SupplierName;
        private System.Windows.Forms.Label ux_PriceLabel;
        private System.Windows.Forms.Label ux_QuantityLabel;
        private System.Windows.Forms.Label ux_PartIDLabel;
        private System.Windows.Forms.Label ux_SupplierNameLabel;
        private System.Windows.Forms.DataGridView ux_OrderGrid;
    }
}
