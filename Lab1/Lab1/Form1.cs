using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy;

        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;
        int num = 0;
        private void btLaunch_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                num += 1;
                t = 0;
                x = 0;
                y = edHeight.Value;
                v0 = edSpeed.Value;
                double a = (double)edAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = edSize.Value;
                m = edWeight.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series.Add(num.ToString());
                chart1.Series[num.ToString()].ChartType= System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart1.Series[num.ToString()].BorderWidth = 3;
                chart1.Series[num.ToString()].Points.AddXY(x, y);
                timer1.Start();
            }

        }
        decimal dt;
        decimal ymax = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dt= eddt.Value;
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            chart1.Series[num.ToString()].Points.AddXY(x, y);
            if (ymax < y) ymax = y;
            if (y <= 0) timer1.Stop();
            tbStep.Text = "" + dt;
            tbDis.Text = "" + x;
            tbMaxh.Text = "" + ymax;
            tbSpeed.Text = "" + v;
        }
    }
}
