namespace _560DB
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ux_TabPanel = new System.Windows.Forms.Panel();
            this.ux_ActiveBar = new System.Windows.Forms.Panel();
            this.ux_TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ux_Analyze = new System.Windows.Forms.Button();
            this.ux_OrderParts = new System.Windows.Forms.Button();
            this.ux_SalesPortal = new System.Windows.Forms.Button();
            this.ux_PartEntry = new System.Windows.Forms.Button();
            this.uxJobEntry = new System.Windows.Forms.Button();
            this.ux_PartSearch = new System.Windows.Forms.Button();
            this.ux_JobSearch = new System.Windows.Forms.Button();
            this.ux_Home = new System.Windows.Forms.Button();
            this.ux_TopPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ux_Employees = new System.Windows.Forms.Button();
            this.employeeControl1 = new _560DB.EmployeeControl();
            this.orderPartsControl1 = new _560DB.OrderPartsControl();
            this.salesPortalControl1 = new _560DB.SalesPortalControl();
            this.partEntryControl1 = new _560DB.PartEntryControl();
            this.jobEntryControl1 = new _560DB.JobEntryControl();
            this.partSearchControl1 = new _560DB.PartSearchControl();
            this.jobSearchControl1 = new _560DB.JobSearchControl();
            this.homeControl1 = new _560DB.HomeControl();
            this.analyzeControl1 = new _560DB.AnalyzeControl();
            this.ux_TabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ux_TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ux_TabPanel
            // 
            this.ux_TabPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ux_TabPanel.Controls.Add(this.ux_Employees);
            this.ux_TabPanel.Controls.Add(this.ux_ActiveBar);
            this.ux_TabPanel.Controls.Add(this.ux_TitleLabel);
            this.ux_TabPanel.Controls.Add(this.pictureBox1);
            this.ux_TabPanel.Controls.Add(this.ux_Analyze);
            this.ux_TabPanel.Controls.Add(this.ux_OrderParts);
            this.ux_TabPanel.Controls.Add(this.ux_SalesPortal);
            this.ux_TabPanel.Controls.Add(this.ux_PartEntry);
            this.ux_TabPanel.Controls.Add(this.uxJobEntry);
            this.ux_TabPanel.Controls.Add(this.ux_PartSearch);
            this.ux_TabPanel.Controls.Add(this.ux_JobSearch);
            this.ux_TabPanel.Controls.Add(this.ux_Home);
            this.ux_TabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ux_TabPanel.Location = new System.Drawing.Point(0, 0);
            this.ux_TabPanel.Name = "ux_TabPanel";
            this.ux_TabPanel.Size = new System.Drawing.Size(150, 567);
            this.ux_TabPanel.TabIndex = 0;
            // 
            // ux_ActiveBar
            // 
            this.ux_ActiveBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ux_ActiveBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ux_ActiveBar.Location = new System.Drawing.Point(0, 60);
            this.ux_ActiveBar.Name = "ux_ActiveBar";
            this.ux_ActiveBar.Size = new System.Drawing.Size(10, 47);
            this.ux_ActiveBar.TabIndex = 2;
            // 
            // ux_TitleLabel
            // 
            this.ux_TitleLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_TitleLabel.Location = new System.Drawing.Point(53, 14);
            this.ux_TitleLabel.Name = "ux_TitleLabel";
            this.ux_TitleLabel.Size = new System.Drawing.Size(61, 37);
            this.ux_TitleLabel.TabIndex = 4;
            this.ux_TitleLabel.Text = "Business Inventory System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 37);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ux_Analyze
            // 
            this.ux_Analyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Analyze.FlatAppearance.BorderSize = 0;
            this.ux_Analyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_Analyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_Analyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Analyze.ForeColor = System.Drawing.Color.White;
            this.ux_Analyze.Location = new System.Drawing.Point(0, 431);
            this.ux_Analyze.Name = "ux_Analyze";
            this.ux_Analyze.Size = new System.Drawing.Size(150, 47);
            this.ux_Analyze.TabIndex = 3;
            this.ux_Analyze.Text = "Analyze";
            this.ux_Analyze.UseVisualStyleBackColor = true;
            this.ux_Analyze.Click += new System.EventHandler(this.ux_Analyze_Click);
            // 
            // ux_OrderParts
            // 
            this.ux_OrderParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_OrderParts.FlatAppearance.BorderSize = 0;
            this.ux_OrderParts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_OrderParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_OrderParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_OrderParts.ForeColor = System.Drawing.Color.White;
            this.ux_OrderParts.Location = new System.Drawing.Point(0, 378);
            this.ux_OrderParts.Name = "ux_OrderParts";
            this.ux_OrderParts.Size = new System.Drawing.Size(150, 47);
            this.ux_OrderParts.TabIndex = 3;
            this.ux_OrderParts.Text = "Order Parts";
            this.ux_OrderParts.UseVisualStyleBackColor = true;
            this.ux_OrderParts.Click += new System.EventHandler(this.ux_OrderParts_Click);
            // 
            // ux_SalesPortal
            // 
            this.ux_SalesPortal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_SalesPortal.FlatAppearance.BorderSize = 0;
            this.ux_SalesPortal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_SalesPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_SalesPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_SalesPortal.ForeColor = System.Drawing.Color.White;
            this.ux_SalesPortal.Location = new System.Drawing.Point(0, 325);
            this.ux_SalesPortal.Name = "ux_SalesPortal";
            this.ux_SalesPortal.Size = new System.Drawing.Size(150, 47);
            this.ux_SalesPortal.TabIndex = 3;
            this.ux_SalesPortal.Text = "Sales Portal";
            this.ux_SalesPortal.UseVisualStyleBackColor = true;
            this.ux_SalesPortal.Click += new System.EventHandler(this.ux_SalesPortal_Click);
            // 
            // ux_PartEntry
            // 
            this.ux_PartEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_PartEntry.FlatAppearance.BorderSize = 0;
            this.ux_PartEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_PartEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_PartEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartEntry.ForeColor = System.Drawing.Color.White;
            this.ux_PartEntry.Location = new System.Drawing.Point(0, 272);
            this.ux_PartEntry.Name = "ux_PartEntry";
            this.ux_PartEntry.Size = new System.Drawing.Size(150, 47);
            this.ux_PartEntry.TabIndex = 3;
            this.ux_PartEntry.Text = "Part Entry";
            this.ux_PartEntry.UseVisualStyleBackColor = true;
            this.ux_PartEntry.Click += new System.EventHandler(this.ux_PartEntry_Click);
            // 
            // uxJobEntry
            // 
            this.uxJobEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxJobEntry.FlatAppearance.BorderSize = 0;
            this.uxJobEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.uxJobEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxJobEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxJobEntry.ForeColor = System.Drawing.Color.White;
            this.uxJobEntry.Location = new System.Drawing.Point(0, 219);
            this.uxJobEntry.Name = "uxJobEntry";
            this.uxJobEntry.Size = new System.Drawing.Size(150, 47);
            this.uxJobEntry.TabIndex = 3;
            this.uxJobEntry.Text = "Job Entry";
            this.uxJobEntry.UseVisualStyleBackColor = true;
            this.uxJobEntry.Click += new System.EventHandler(this.uxJobEntry_Click);
            // 
            // ux_PartSearch
            // 
            this.ux_PartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_PartSearch.FlatAppearance.BorderSize = 0;
            this.ux_PartSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_PartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_PartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartSearch.ForeColor = System.Drawing.Color.White;
            this.ux_PartSearch.Location = new System.Drawing.Point(0, 166);
            this.ux_PartSearch.Name = "ux_PartSearch";
            this.ux_PartSearch.Size = new System.Drawing.Size(150, 47);
            this.ux_PartSearch.TabIndex = 3;
            this.ux_PartSearch.Text = "Part Search";
            this.ux_PartSearch.UseVisualStyleBackColor = true;
            this.ux_PartSearch.Click += new System.EventHandler(this.ux_PartSearch_Click);
            // 
            // ux_JobSearch
            // 
            this.ux_JobSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_JobSearch.FlatAppearance.BorderSize = 0;
            this.ux_JobSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_JobSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_JobSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_JobSearch.ForeColor = System.Drawing.Color.White;
            this.ux_JobSearch.Location = new System.Drawing.Point(0, 113);
            this.ux_JobSearch.Name = "ux_JobSearch";
            this.ux_JobSearch.Size = new System.Drawing.Size(150, 47);
            this.ux_JobSearch.TabIndex = 3;
            this.ux_JobSearch.Text = "Job Search";
            this.ux_JobSearch.UseVisualStyleBackColor = true;
            this.ux_JobSearch.Click += new System.EventHandler(this.ux_JobSearch_Click);
            // 
            // ux_Home
            // 
            this.ux_Home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Home.FlatAppearance.BorderSize = 0;
            this.ux_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Home.ForeColor = System.Drawing.Color.White;
            this.ux_Home.Location = new System.Drawing.Point(0, 60);
            this.ux_Home.Name = "ux_Home";
            this.ux_Home.Size = new System.Drawing.Size(150, 47);
            this.ux_Home.TabIndex = 2;
            this.ux_Home.Text = "Home";
            this.ux_Home.UseVisualStyleBackColor = true;
            this.ux_Home.Click += new System.EventHandler(this.ux_Home_Click);
            // 
            // ux_TopPanel
            // 
            this.ux_TopPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ux_TopPanel.Controls.Add(this.button1);
            this.ux_TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_TopPanel.Location = new System.Drawing.Point(150, 0);
            this.ux_TopPanel.Name = "ux_TopPanel";
            this.ux_TopPanel.Size = new System.Drawing.Size(751, 32);
            this.ux_TopPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(702, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 31);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ux_Employees
            // 
            this.ux_Employees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Employees.FlatAppearance.BorderSize = 0;
            this.ux_Employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ux_Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Employees.ForeColor = System.Drawing.Color.White;
            this.ux_Employees.Location = new System.Drawing.Point(0, 484);
            this.ux_Employees.Name = "ux_Employees";
            this.ux_Employees.Size = new System.Drawing.Size(150, 47);
            this.ux_Employees.TabIndex = 5;
            this.ux_Employees.Text = "Employees";
            this.ux_Employees.UseVisualStyleBackColor = true;
            this.ux_Employees.Click += new System.EventHandler(this.ux_Employees_Click);
            // 
            // employeeControl1
            // 
            this.employeeControl1.Location = new System.Drawing.Point(150, 32);
            this.employeeControl1.Name = "employeeControl1";
            this.employeeControl1.Size = new System.Drawing.Size(751, 535);
            this.employeeControl1.TabIndex = 9;
            // 
            // orderPartsControl1
            // 
            this.orderPartsControl1.Location = new System.Drawing.Point(150, 32);
            this.orderPartsControl1.Name = "orderPartsControl1";
            this.orderPartsControl1.Size = new System.Drawing.Size(751, 535);
            this.orderPartsControl1.TabIndex = 8;
            // 
            // salesPortalControl1
            // 
            this.salesPortalControl1.Location = new System.Drawing.Point(150, 32);
            this.salesPortalControl1.Name = "salesPortalControl1";
            this.salesPortalControl1.Size = new System.Drawing.Size(751, 535);
            this.salesPortalControl1.TabIndex = 7;
            // 
            // partEntryControl1
            // 
            this.partEntryControl1.Location = new System.Drawing.Point(150, 32);
            this.partEntryControl1.Name = "partEntryControl1";
            this.partEntryControl1.Size = new System.Drawing.Size(751, 535);
            this.partEntryControl1.TabIndex = 6;
            // 
            // jobEntryControl1
            // 
            this.jobEntryControl1.Location = new System.Drawing.Point(150, 32);
            this.jobEntryControl1.Name = "jobEntryControl1";
            this.jobEntryControl1.Size = new System.Drawing.Size(751, 535);
            this.jobEntryControl1.TabIndex = 5;
            // 
            // partSearchControl1
            // 
            this.partSearchControl1.Location = new System.Drawing.Point(150, 32);
            this.partSearchControl1.Name = "partSearchControl1";
            this.partSearchControl1.Size = new System.Drawing.Size(751, 535);
            this.partSearchControl1.TabIndex = 4;
            // 
            // jobSearchControl1
            // 
            this.jobSearchControl1.Location = new System.Drawing.Point(150, 32);
            this.jobSearchControl1.Name = "jobSearchControl1";
            this.jobSearchControl1.Size = new System.Drawing.Size(751, 535);
            this.jobSearchControl1.TabIndex = 3;
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(150, 32);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(751, 535);
            this.homeControl1.TabIndex = 2;
            // 
            // analyzeControl1
            // 
            this.analyzeControl1.Location = new System.Drawing.Point(150, 32);
            this.analyzeControl1.Name = "analyzeControl1";
            this.analyzeControl1.Size = new System.Drawing.Size(751, 535);
            this.analyzeControl1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 567);
            this.Controls.Add(this.analyzeControl1);
            this.Controls.Add(this.employeeControl1);
            this.Controls.Add(this.orderPartsControl1);
            this.Controls.Add(this.salesPortalControl1);
            this.Controls.Add(this.partEntryControl1);
            this.Controls.Add(this.jobEntryControl1);
            this.Controls.Add(this.partSearchControl1);
            this.Controls.Add(this.jobSearchControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.ux_TopPanel);
            this.Controls.Add(this.ux_TabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ux_TabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ux_TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ux_TabPanel;
        private System.Windows.Forms.Panel ux_TopPanel;
        private System.Windows.Forms.Button ux_Home;
        private System.Windows.Forms.Button ux_Analyze;
        private System.Windows.Forms.Button ux_OrderParts;
        private System.Windows.Forms.Button ux_SalesPortal;
        private System.Windows.Forms.Button ux_PartEntry;
        private System.Windows.Forms.Button uxJobEntry;
        private System.Windows.Forms.Button ux_PartSearch;
        private System.Windows.Forms.Button ux_JobSearch;
        private System.Windows.Forms.Label ux_TitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ux_ActiveBar;
        private System.Windows.Forms.Button button1;
        private HomeControl homeControl1;
        private JobSearchControl jobSearchControl1;
        private PartSearchControl partSearchControl1;
        private JobEntryControl jobEntryControl1;
        private PartEntryControl partEntryControl1;
        private SalesPortalControl salesPortalControl1;
        private OrderPartsControl orderPartsControl1;
        private System.Windows.Forms.Button ux_Employees;
        private EmployeeControl employeeControl1;
        private AnalyzeControl analyzeControl1;
    }
}

