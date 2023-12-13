using System.Windows.Forms.DataVisualization.Charting;

namespace FrekansModulasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form'un Paint olayýna bir olay dinleyici ekleyin
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Chart nesnesi oluþturun
            Chart chart = new Chart();
            chart.Size = new Size(600, 400);

            // ChartArea oluþturun ve grafiðe ekleyin
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Seri oluþturun ve grafiðe ekleyin
            Series series = new Series();
            chart.Series.Add(series);

            // Frekans modülasyonu parametreleri tanýmlayýn
            double fb = 25, ft = 300, m = 10, t1 = 0, t2 = 0.1, ta = 0.001;
            double wb = 2 * Math.PI * fb; // Taþýyýcý frekansýn açýsal frekansý
            double wt = 2 * Math.PI * ft; // Modüle eden sinyalin açýsal frekansý

            // Belirtilen zaman aralýðýnda frekans modülasyonu iþlemini gerçekleþtirin
            for (double t = t1; t <= t2; t += ta)
            {
                // Frekans modülasyonu iþlemi
                double v = Math.Sin(wt * t + m * Math.Sin(wb * t));

                // Oluþturulan veri noktalarýný grafiðe ekleyin
                series.Points.AddXY(t, v);
            }

            // Grafiði forma ekleyin
            Controls.Add(chart);
        }
    }
}