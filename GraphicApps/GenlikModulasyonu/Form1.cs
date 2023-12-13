using System.Windows.Forms.DataVisualization.Charting;

namespace GenlikModulasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form'un Paint olay�na bir olay dinleyici ekleyin
            this.Paint += Form1_Paint;
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

            // Mod�lasyon parametreleri tan�mlay�n
            int ab = 1, fb = 1, at = 1, ft = 20, t1 = 0, t2 = 2;
            double ta = 0.001;
            double m = ab / at; // Mod�lasyon �ndeksi
            double wb = 2 * Math.PI * fb; // Ta��y�c� frekans�n a��sal frekans�
            double wt = 2 * Math.PI * ft; // Mod�le eden sinyalin a��sal frekans�

            // Zaman aral��� i�inde mod�lasyon i�lemini ger�ekle�tirin
            for (double i = t1; i < t2; i += ta)
            {
                // Genlik mod�lasyonu i�lemi
                double v = (1 + m * Math.Sin(wb * i)) * Math.Sin(wt * i);

                // Olu�turulan veri noktalar�n� grafi�e ekleyin
                series.Points.AddXY(i, v);
            }

            // Grafi�i forma ekleyin
            Controls.Add(chart);
        }
    }
}