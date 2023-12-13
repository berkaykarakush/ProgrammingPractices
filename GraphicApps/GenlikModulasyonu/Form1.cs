using System.Windows.Forms.DataVisualization.Charting;

namespace GenlikModulasyonu
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

            // Modülasyon parametreleri tanýmlayýn
            int ab = 1, fb = 1, at = 1, ft = 20, t1 = 0, t2 = 2;
            double ta = 0.001;
            double m = ab / at; // Modülasyon Ýndeksi
            double wb = 2 * Math.PI * fb; // Taþýyýcý frekansýn açýsal frekansý
            double wt = 2 * Math.PI * ft; // Modüle eden sinyalin açýsal frekansý

            // Zaman aralýðý içinde modülasyon iþlemini gerçekleþtirin
            for (double i = t1; i < t2; i += ta)
            {
                // Genlik modülasyonu iþlemi
                double v = (1 + m * Math.Sin(wb * i)) * Math.Sin(wt * i);

                // Oluþturulan veri noktalarýný grafiðe ekleyin
                series.Points.AddXY(i, v);
            }

            // Grafiði forma ekleyin
            Controls.Add(chart);
        }
    }
}