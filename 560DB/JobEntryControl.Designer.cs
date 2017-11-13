namespace _560DB
{
    partial class JobEntryControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobEntryControl));
            this.ux_JobIDLabel = new System.Windows.Forms.Label();
            this.ux_ProcessIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ux_JobID = new System.Windows.Forms.TextBox();
            this.ux_ProcessID = new System.Windows.Forms.TextBox();
            this.ux_Complete = new System.Windows.Forms.CheckBox();
            this.checkmarks = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ux_InsertUpdate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_JobIDLabel
            // 
            this.ux_JobIDLabel.AutoSize = true;
            this.ux_JobIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_JobIDLabel.Location = new System.Drawing.Point(229, 61);
            this.ux_JobIDLabel.Name = "ux_JobIDLabel";
            this.ux_JobIDLabel.Size = new System.Drawing.Size(56, 21);
            this.ux_JobIDLabel.TabIndex = 0;
            this.ux_JobIDLabel.Text = "Job ID:";
            // 
            // ux_ProcessIDLabel
            // 
            this.ux_ProcessIDLabel.AutoSize = true;
            this.ux_ProcessIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ProcessIDLabel.Location = new System.Drawing.Point(200, 120);
            this.ux_ProcessIDLabel.Name = "ux_ProcessIDLabel";
            this.ux_ProcessIDLabel.Size = new System.Drawing.Size(85, 21);
            this.ux_ProcessIDLabel.TabIndex = 1;
            this.ux_ProcessIDLabel.Text = "Process ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = " Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Completed:";
            // 
            // ux_JobID
            // 
            this.ux_JobID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_JobID.Location = new System.Drawing.Point(330, 57);
            this.ux_JobID.Name = "ux_JobID";
            this.ux_JobID.Size = new System.Drawing.Size(173, 25);
            this.ux_JobID.TabIndex = 4;
            this.ux_JobID.Leave += new System.EventHandler(this.ux_JobID_Leave);
            // 
            // ux_ProcessID
            // 
            this.ux_ProcessID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_ProcessID.Location = new System.Drawing.Point(330, 116);
            this.ux_ProcessID.Name = "ux_ProcessID";
            this.ux_ProcessID.Size = new System.Drawing.Size(173, 25);
            this.ux_ProcessID.TabIndex = 5;
            // 
            // ux_Complete
            // 
            this.ux_Complete.Appearance = System.Windows.Forms.Appearance.Button;
            this.ux_Complete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ux_Complete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.ux_Complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_Complete.ImageIndex = 0;
            this.ux_Complete.ImageList = this.checkmarks;
            this.ux_Complete.Location = new System.Drawing.Point(330, 254);
            this.ux_Complete.Margin = new System.Windows.Forms.Padding(0);
            this.ux_Complete.Name = "ux_Complete";
            this.ux_Complete.Size = new System.Drawing.Size(27, 27);
            this.ux_Complete.TabIndex = 7;
            this.ux_Complete.UseVisualStyleBackColor = true;
            this.ux_Complete.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkmarks
            // 
            this.checkmarks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("checkmarks.ImageStream")));
            this.checkmarks.TransparentColor = System.Drawing.Color.Transparent;
            this.checkmarks.Images.SetKeyName(0, "uncheckmark.png");
            this.checkmarks.Images.SetKeyName(1, "checkmark.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 25);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // ux_InsertUpdate
            // 
            this.ux_InsertUpdate.BackColor = System.Drawing.Color.Gray;
            this.ux_InsertUpdate.FlatAppearance.BorderSize = 0;
            this.ux_InsertUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ux_InsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_InsertUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_InsertUpdate.Location = new System.Drawing.Point(269, 437);
            this.ux_InsertUpdate.Name = "ux_InsertUpdate";
            this.ux_InsertUpdate.Size = new System.Drawing.Size(218, 49);
            this.ux_InsertUpdate.TabIndex = 10;
            this.ux_InsertUpdate.Text = "Insert/Update";
            this.ux_InsertUpdate.UseVisualStyleBackColor = false;
            this.ux_InsertUpdate.Click += new System.EventHandler(this.ux_InsertUpdate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(330, 185);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown1.TabIndex = 11;
            // 
            // JobEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ux_InsertUpdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ux_Complete);
            this.Controls.Add(this.ux_ProcessID);
            this.Controls.Add(this.ux_JobID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ux_ProcessIDLabel);
            this.Controls.Add(this.ux_JobIDLabel);
            this.Name = "JobEntryControl";
            this.Size = new System.Drawing.Size(751, 535);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ux_JobIDLabel;
        private System.Windows.Forms.Label ux_ProcessIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ux_JobID;
        private System.Windows.Forms.TextBox ux_ProcessID;
        private System.Windows.Forms.CheckBox ux_Complete;
        private System.Windows.Forms.ImageList checkmarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ux_InsertUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
