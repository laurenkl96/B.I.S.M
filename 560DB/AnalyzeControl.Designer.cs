namespace _560DB
{
    partial class AnalyzeControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ux_Analyze = new System.Windows.Forms.Button();
            this.ux_PartID = new System.Windows.Forms.TextBox();
            this.ux_PartIDLabel = new System.Windows.Forms.Label();
            this.ux_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_Analyze
            // 
            this.ux_Analyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ux_Analyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.ux_Analyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ux_Analyze.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Analyze.Location = new System.Drawing.Point(626, 23);
            this.ux_Analyze.Name = "ux_Analyze";
            this.ux_Analyze.Size = new System.Drawing.Size(97, 50);
            this.ux_Analyze.TabIndex = 16;
            this.ux_Analyze.Text = "Analyze";
            this.ux_Analyze.UseVisualStyleBackColor = false;
            this.ux_Analyze.Click += new System.EventHandler(this.ux_Analyze_Click);
            // 
            // ux_PartID
            // 
            this.ux_PartID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartID.Location = new System.Drawing.Point(127, 23);
            this.ux_PartID.Name = "ux_PartID";
            this.ux_PartID.Size = new System.Drawing.Size(469, 25);
            this.ux_PartID.TabIndex = 15;
            // 
            // ux_PartIDLabel
            // 
            this.ux_PartIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_PartIDLabel.AutoSize = true;
            this.ux_PartIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_PartIDLabel.Location = new System.Drawing.Point(32, 27);
            this.ux_PartIDLabel.Name = "ux_PartIDLabel";
            this.ux_PartIDLabel.Size = new System.Drawing.Size(56, 21);
            this.ux_PartIDLabel.TabIndex = 14;
            this.ux_PartIDLabel.Text = "Part ID";
            // 
            // ux_Chart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.ux_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ux_Chart.Legends.Add(legend1);
            this.ux_Chart.Location = new System.Drawing.Point(29, 84);
            this.ux_Chart.Name = "ux_Chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Parts Use";
            this.ux_Chart.Series.Add(series1);
            this.ux_Chart.Size = new System.Drawing.Size(694, 410);
            this.ux_Chart.TabIndex = 17;
            this.ux_Chart.Text = "Analysis";
            // 
            // AnalyzeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ux_Chart);
            this.Controls.Add(this.ux_Analyze);
            this.Controls.Add(this.ux_PartID);
            this.Controls.Add(this.ux_PartIDLabel);
            this.Name = "AnalyzeControl";
            this.Size = new System.Drawing.Size(751, 535);
            ((System.ComponentModel.ISupportInitialize)(this.ux_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_Analyze;
        private System.Windows.Forms.TextBox ux_PartID;
        private System.Windows.Forms.Label ux_PartIDLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ux_Chart;
    }
}
