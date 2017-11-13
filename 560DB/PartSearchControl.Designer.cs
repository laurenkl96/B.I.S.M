namespace _560DB
{
    partial class PartSearchControl
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
            this.ux_PartSearch = new System.Windows.Forms.Button();
            this.ux_NameSearch = new System.Windows.Forms.Button();
            this.ux_SearchLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ux_SearchButton = new System.Windows.Forms.Button();
            this.ux_ResultGrid = new System.Windows.Forms.DataGridView();
            this.ux_ResultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ux_ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_PartSearch
            // 
            this.ux_PartSearch.BackColor = System.Drawing.Color.Transparent;
            this.ux_PartSearch.FlatAppearance.BorderSize = 0;
            this.ux_PartSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ux_PartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_PartSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartSearch.Location = new System.Drawing.Point(0, 0);
            this.ux_PartSearch.Name = "ux_PartSearch";
            this.ux_PartSearch.Size = new System.Drawing.Size(375, 40);
            this.ux_PartSearch.TabIndex = 0;
            this.ux_PartSearch.Text = "Part ID";
            this.ux_PartSearch.UseVisualStyleBackColor = false;
            this.ux_PartSearch.Click += new System.EventHandler(this.ux_PartSearch_Click);
            // 
            // ux_NameSearch
            // 
            this.ux_NameSearch.BackColor = System.Drawing.Color.Transparent;
            this.ux_NameSearch.FlatAppearance.BorderSize = 0;
            this.ux_NameSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ux_NameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_NameSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_NameSearch.Location = new System.Drawing.Point(375, 0);
            this.ux_NameSearch.Name = "ux_NameSearch";
            this.ux_NameSearch.Size = new System.Drawing.Size(376, 40);
            this.ux_NameSearch.TabIndex = 1;
            this.ux_NameSearch.Text = "Part Name";
            this.ux_NameSearch.UseVisualStyleBackColor = false;
            this.ux_NameSearch.Click += new System.EventHandler(this.ux_NameSearch_Click);
            // 
            // ux_SearchLabel
            // 
            this.ux_SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_SearchLabel.AutoSize = true;
            this.ux_SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_SearchLabel.Location = new System.Drawing.Point(43, 60);
            this.ux_SearchLabel.Name = "ux_SearchLabel";
            this.ux_SearchLabel.Size = new System.Drawing.Size(63, 21);
            this.ux_SearchLabel.TabIndex = 2;
            this.ux_SearchLabel.Text = "Part ID: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 25);
            this.textBox1.TabIndex = 3;
            // 
            // ux_SearchButton
            // 
            this.ux_SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ux_SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.ux_SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_SearchButton.Location = new System.Drawing.Point(637, 56);
            this.ux_SearchButton.Name = "ux_SearchButton";
            this.ux_SearchButton.Size = new System.Drawing.Size(97, 50);
            this.ux_SearchButton.TabIndex = 6;
            this.ux_SearchButton.Text = "Search";
            this.ux_SearchButton.UseVisualStyleBackColor = false;
            // 
            // ux_ResultGrid
            // 
            this.ux_ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_ResultGrid.Location = new System.Drawing.Point(15, 112);
            this.ux_ResultGrid.Name = "ux_ResultGrid";
            this.ux_ResultGrid.Size = new System.Drawing.Size(719, 398);
            this.ux_ResultGrid.TabIndex = 7;
            // 
            // ux_ResultsLabel
            // 
            this.ux_ResultsLabel.AutoSize = true;
            this.ux_ResultsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ResultsLabel.Location = new System.Drawing.Point(624, 515);
            this.ux_ResultsLabel.Name = "ux_ResultsLabel";
            this.ux_ResultsLabel.Size = new System.Drawing.Size(84, 13);
            this.ux_ResultsLabel.TabIndex = 8;
            this.ux_ResultsLabel.Text = "Rows Found: 0";
            // 
            // PartSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ux_ResultsLabel);
            this.Controls.Add(this.ux_ResultGrid);
            this.Controls.Add(this.ux_SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ux_SearchLabel);
            this.Controls.Add(this.ux_NameSearch);
            this.Controls.Add(this.ux_PartSearch);
            this.Name = "PartSearchControl";
            this.Size = new System.Drawing.Size(751, 535);
            ((System.ComponentModel.ISupportInitialize)(this.ux_ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_PartSearch;
        private System.Windows.Forms.Button ux_NameSearch;
        private System.Windows.Forms.Label ux_SearchLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ux_SearchButton;
        private System.Windows.Forms.DataGridView ux_ResultGrid;
        private System.Windows.Forms.Label ux_ResultsLabel;
    }
}
