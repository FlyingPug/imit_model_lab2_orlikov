using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                currentPrice1 = (double)inputPrice1.Value;
                currentPrice2 = (double)inputPrice2.Value;
                MyChart.Series[0].Points.Clear();
                MyChart.Series[1].Points.Clear();
                counter = 0;
                timer1.Start();
            }
        }

        const double k = 0.02;
        Random rnd = new Random();
        double currentPrice1;
        double currentPrice2;
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            MyChart.Series[0].Points.AddXY(counter, currentPrice1);
            MyChart.Series[1].Points.AddXY(counter, currentPrice2);
            currentPrice1 = currentPrice1 * (1 + k * (rnd.NextDouble() - 0.5));
            currentPrice2 = currentPrice2 * (1 + k * (rnd.NextDouble() - 0.5));
            counter++;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}