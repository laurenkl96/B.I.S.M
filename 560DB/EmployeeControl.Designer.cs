namespace _560DB
{
    partial class EmployeeControl
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
            this.ux_ResultsLabel = new System.Windows.Forms.Label();
            this.ux_ResultGrid = new System.Windows.Forms.DataGridView();
            this.ux_SearchButton = new System.Windows.Forms.Button();
            this.ux_Parameter = new System.Windows.Forms.TextBox();
            this.ux_SearchLabel = new System.Windows.Forms.Label();
            this.ux_JobSearch = new System.Windows.Forms.Button();
            this.ux_NameSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ux_ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_ResultsLabel
            // 
            this.ux_ResultsLabel.AutoSize = true;
            this.ux_ResultsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ResultsLabel.Location = new System.Drawing.Point(624, 515);
            this.ux_ResultsLabel.Name = "ux_ResultsLabel";
            this.ux_ResultsLabel.Size = new System.Drawing.Size(84, 13);
            this.ux_ResultsLabel.TabIndex = 15;
            this.ux_ResultsLabel.Text = "Rows Found: 0";
            // 
            // ux_ResultGrid
            // 
            this.ux_ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ux_ResultGrid.Location = new System.Drawing.Point(15, 112);
            this.ux_ResultGrid.Name = "ux_ResultGrid";
            this.ux_ResultGrid.Size = new System.Drawing.Size(719, 398);
            this.ux_ResultGrid.TabIndex = 14;
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
            this.ux_SearchButton.TabIndex = 13;
            this.ux_SearchButton.Text = "Search";
            this.ux_SearchButton.UseVisualStyleBackColor = false;
            // 
            // ux_Parameter
            // 
            this.ux_Parameter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Parameter.Location = new System.Drawing.Point(138, 56);
            this.ux_Parameter.Name = "ux_Parameter";
            this.ux_Parameter.Size = new System.Drawing.Size(469, 25);
            this.ux_Parameter.TabIndex = 12;
            // 
            // ux_SearchLabel
            // 
            this.ux_SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_SearchLabel.AutoSize = true;
            this.ux_SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_SearchLabel.Location = new System.Drawing.Point(43, 60);
            this.ux_SearchLabel.Name = "ux_SearchLabel";
            this.ux_SearchLabel.Size = new System.Drawing.Size(55, 21);
            this.ux_SearchLabel.TabIndex = 11;
            this.ux_SearchLabel.Text = "Name:";
            // 
            // ux_JobSearch
            // 
            this.ux_JobSearch.BackColor = System.Drawing.Color.Transparent;
            this.ux_JobSearch.FlatAppearance.BorderSize = 0;
            this.ux_JobSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ux_JobSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_JobSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_JobSearch.Location = new System.Drawing.Point(375, 0);
            this.ux_JobSearch.Name = "ux_JobSearch";
            this.ux_JobSearch.Size = new System.Drawing.Size(376, 40);
            this.ux_JobSearch.TabIndex = 10;
            this.ux_JobSearch.Text = "Job Title";
            this.ux_JobSearch.UseVisualStyleBackColor = false;
            this.ux_JobSearch.Click += new System.EventHandler(this.ux_JobSearch_Click);
            // 
            // ux_NameSearch
            // 
            this.ux_NameSearch.BackColor = System.Drawing.Color.Transparent;
            this.ux_NameSearch.FlatAppearance.BorderSize = 0;
            this.ux_NameSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ux_NameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_NameSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_NameSearch.Location = new System.Drawing.Point(0, 0);
            this.ux_NameSearch.Name = "ux_NameSearch";
            this.ux_NameSearch.Size = new System.Drawing.Size(375, 40);
            this.ux_NameSearch.TabIndex = 9;
            this.ux_NameSearch.Text = "Name";
            this.ux_NameSearch.UseVisualStyleBackColor = false;
            this.ux_NameSearch.Click += new System.EventHandler(this.ux_NameSearch_Click);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ux_ResultsLabel);
            this.Controls.Add(this.ux_ResultGrid);
            this.Controls.Add(this.ux_SearchButton);
            this.Controls.Add(this.ux_Parameter);
            this.Controls.Add(this.ux_SearchLabel);
            this.Controls.Add(this.ux_JobSearch);
            this.Controls.Add(this.ux_NameSearch);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(751, 535);
            ((System.ComponentModel.ISupportInitialize)(this.ux_ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ux_ResultsLabel;
        private System.Windows.Forms.DataGridView ux_ResultGrid;
        private System.Windows.Forms.Button ux_SearchButton;
        private System.Windows.Forms.TextBox ux_Parameter;
        private System.Windows.Forms.Label ux_SearchLabel;
        private System.Windows.Forms.Button ux_JobSearch;
        private System.Windows.Forms.Button ux_NameSearch;
    }
}
