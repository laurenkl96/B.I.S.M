namespace _560DB
{
    partial class PartEntryControl
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
            this.ux_InsertUpdate = new System.Windows.Forms.Button();
            this.ux_Date = new System.Windows.Forms.DateTimePicker();
            this.ux_DateLabel = new System.Windows.Forms.Label();
            this.ux_PartName = new System.Windows.Forms.TextBox();
            this.ux_PartID = new System.Windows.Forms.TextBox();
            this.ux_PriceLabel = new System.Windows.Forms.Label();
            this.ux_QuantityLabel = new System.Windows.Forms.Label();
            this.ux_PartNameLabel = new System.Windows.Forms.Label();
            this.ux_PartIDLabel = new System.Windows.Forms.Label();
            this.ux_Quantity = new System.Windows.Forms.NumericUpDown();
            this.ux_Price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_InsertUpdate
            // 
            this.ux_InsertUpdate.BackColor = System.Drawing.Color.Gray;
            this.ux_InsertUpdate.FlatAppearance.BorderSize = 0;
            this.ux_InsertUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ux_InsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_InsertUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_InsertUpdate.Location = new System.Drawing.Point(265, 433);
            this.ux_InsertUpdate.Name = "ux_InsertUpdate";
            this.ux_InsertUpdate.Size = new System.Drawing.Size(218, 49);
            this.ux_InsertUpdate.TabIndex = 21;
            this.ux_InsertUpdate.Text = "Insert/Update";
            this.ux_InsertUpdate.UseVisualStyleBackColor = false;
            this.ux_InsertUpdate.Click += new System.EventHandler(this.ux_InsertUpdate_Click);
            // 
            // ux_Date
            // 
            this.ux_Date.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Date.Location = new System.Drawing.Point(326, 311);
            this.ux_Date.Name = "ux_Date";
            this.ux_Date.Size = new System.Drawing.Size(233, 25);
            this.ux_Date.TabIndex = 20;
            // 
            // ux_DateLabel
            // 
            this.ux_DateLabel.AutoSize = true;
            this.ux_DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_DateLabel.Location = new System.Drawing.Point(232, 315);
            this.ux_DateLabel.Name = "ux_DateLabel";
            this.ux_DateLabel.Size = new System.Drawing.Size(49, 21);
            this.ux_DateLabel.TabIndex = 19;
            this.ux_DateLabel.Text = "Date: ";
            // 
            // ux_PartName
            // 
            this.ux_PartName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartName.Location = new System.Drawing.Point(326, 112);
            this.ux_PartName.Name = "ux_PartName";
            this.ux_PartName.Size = new System.Drawing.Size(173, 25);
            this.ux_PartName.TabIndex = 16;
            // 
            // ux_PartID
            // 
            this.ux_PartID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartID.Location = new System.Drawing.Point(326, 53);
            this.ux_PartID.Name = "ux_PartID";
            this.ux_PartID.Size = new System.Drawing.Size(173, 25);
            this.ux_PartID.TabIndex = 15;
            this.ux_PartID.Leave += new System.EventHandler(this.ux_PartID_Leave);
            // 
            // ux_PriceLabel
            // 
            this.ux_PriceLabel.AutoSize = true;
            this.ux_PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PriceLabel.Location = new System.Drawing.Point(237, 251);
            this.ux_PriceLabel.Name = "ux_PriceLabel";
            this.ux_PriceLabel.Size = new System.Drawing.Size(47, 21);
            this.ux_PriceLabel.TabIndex = 14;
            this.ux_PriceLabel.Text = "Price:";
            // 
            // ux_QuantityLabel
            // 
            this.ux_QuantityLabel.AutoSize = true;
            this.ux_QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_QuantityLabel.Location = new System.Drawing.Point(204, 185);
            this.ux_QuantityLabel.Name = "ux_QuantityLabel";
            this.ux_QuantityLabel.Size = new System.Drawing.Size(77, 21);
            this.ux_QuantityLabel.TabIndex = 13;
            this.ux_QuantityLabel.Text = " Quantity:";
            // 
            // ux_PartNameLabel
            // 
            this.ux_PartNameLabel.AutoSize = true;
            this.ux_PartNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartNameLabel.Location = new System.Drawing.Point(196, 116);
            this.ux_PartNameLabel.Name = "ux_PartNameLabel";
            this.ux_PartNameLabel.Size = new System.Drawing.Size(86, 21);
            this.ux_PartNameLabel.TabIndex = 12;
            this.ux_PartNameLabel.Text = "Part Name:";
            // 
            // ux_PartIDLabel
            // 
            this.ux_PartIDLabel.AutoSize = true;
            this.ux_PartIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartIDLabel.Location = new System.Drawing.Point(225, 57);
            this.ux_PartIDLabel.Name = "ux_PartIDLabel";
            this.ux_PartIDLabel.Size = new System.Drawing.Size(59, 21);
            this.ux_PartIDLabel.TabIndex = 11;
            this.ux_PartIDLabel.Text = "Part ID:";
            // 
            // ux_Quantity
            // 
            this.ux_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ux_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Quantity.Location = new System.Drawing.Point(326, 185);
            this.ux_Quantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ux_Quantity.Name = "ux_Quantity";
            this.ux_Quantity.Size = new System.Drawing.Size(104, 25);
            this.ux_Quantity.TabIndex = 22;
            // 
            // ux_Price
            // 
            this.ux_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ux_Price.DecimalPlaces = 2;
            this.ux_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Price.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ux_Price.Location = new System.Drawing.Point(326, 247);
            this.ux_Price.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ux_Price.Name = "ux_Price";
            this.ux_Price.Size = new System.Drawing.Size(104, 25);
            this.ux_Price.TabIndex = 23;
            this.ux_Price.ThousandsSeparator = true;
            // 
            // PartEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ux_Price);
            this.Controls.Add(this.ux_Quantity);
            this.Controls.Add(this.ux_InsertUpdate);
            this.Controls.Add(this.ux_Date);
            this.Controls.Add(this.ux_DateLabel);
            this.Controls.Add(this.ux_PartName);
            this.Controls.Add(this.ux_PartID);
            this.Controls.Add(this.ux_PriceLabel);
            this.Controls.Add(this.ux_QuantityLabel);
            this.Controls.Add(this.ux_PartNameLabel);
            this.Controls.Add(this.ux_PartIDLabel);
            this.Name = "PartEntryControl";
            this.Size = new System.Drawing.Size(751, 535);
            ((System.ComponentModel.ISupportInitialize)(this.ux_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_InsertUpdate;
        private System.Windows.Forms.DateTimePicker ux_Date;
        private System.Windows.Forms.Label ux_DateLabel;
        private System.Windows.Forms.TextBox ux_PartName;
        private System.Windows.Forms.TextBox ux_PartID;
        private System.Windows.Forms.Label ux_PriceLabel;
        private System.Windows.Forms.Label ux_QuantityLabel;
        private System.Windows.Forms.Label ux_PartNameLabel;
        private System.Windows.Forms.Label ux_PartIDLabel;
        private System.Windows.Forms.NumericUpDown ux_Quantity;
        private System.Windows.Forms.NumericUpDown ux_Price;
    }
}
