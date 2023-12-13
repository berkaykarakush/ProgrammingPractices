using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FonksiyonGrafigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form'un Paint olay�na bir olay dinleyici ekleyin
            this.Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Chart nesnesi olu�turun
            Chart chart = new Chart();
            chart.Size = new Size(600, 400);

            // ChartArea olu�turun ve grafi�e ekleyin
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Seri olu�turun ve grafi�e ekleyin
            Series series = new Series();
            chart.Series.Add(series);

            double x = -15, y;
            while (x <= 15)
            {
                // Fonksiyonun de�erlerini hesaplay�n ve grafi�e ekleyin
                y = 10 * Math.Sin(5 * x) + 5 * Math.Cos(3 * x);
                series.Points.AddXY(10 * x + 200, 10 * y + 200);
                x += 0.001;
            }

            // Grafi�i forma ekleyin
            Controls.Add(chart);
        }
    }
}
