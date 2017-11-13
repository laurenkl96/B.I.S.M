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
    public partial class AnalyzeControl : UserControl
    {
        public AnalyzeControl()
        {
            InitializeComponent();
        }

        private void ux_Analyze_Click(object sender, EventArgs e)
        {
            ux_Chart.Series["Parts Use"].Points.Clear();
            ux_Chart.Series["Parts Use"].Points.AddXY("11-2016", 59);
            ux_Chart.Series["Parts Use"].Points.AddXY("12-2016", 68);
            ux_Chart.Series["Parts Use"].Points.AddXY("1-2017", 50);
            ux_Chart.Series["Parts Use"].Points.AddXY("2-2017", 38);
            ux_Chart.Series["Parts Use"].Points.AddXY("3-2017", 43);
            ux_Chart.Series["Parts Use"].Points.AddXY("4-2017", 40);
            ux_Chart.Series["Parts Use"].Points.AddXY("5-2017", 45);
            ux_Chart.Series["Parts Use"].Points.AddXY("6-2017", 54);
            ux_Chart.Series["Parts Use"].Points.AddXY("7-2017", 43);
            ux_Chart.Series["Parts Use"].Points.AddXY("8-2017", 58);
            ux_Chart.Series["Parts Use"].Points.AddXY("9-2017", 37);
            ux_Chart.Series["Parts Use"].Points.AddXY("10-2017", 30);
        }
    }
}
