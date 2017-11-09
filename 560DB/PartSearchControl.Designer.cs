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
            this.button1 = new System.Windows.Forms.Button();
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
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(375, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Part ID";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PartSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ux_PartSearch);
            this.Name = "PartSearchControl";
            this.Size = new System.Drawing.Size(751, 535);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ux_PartSearch;
        private System.Windows.Forms.Button button1;
    }
}
