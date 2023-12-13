using System.Windows.Forms.DataVisualization.Charting;

namespace FrekansModulasyonu
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

            // Frekans mod�lasyonu parametreleri tan�mlay�n
            double fb = 25, ft = 300, m = 10, t1 = 0, t2 = 0.1, ta = 0.001;
            double wb = 2 * Math.PI * fb; // Ta��y�c� frekans�n a��sal frekans�
            double wt = 2 * Math.PI * ft; // Mod�le eden sinyalin a��sal frekans�

            // Belirtilen zaman aral���nda frekans mod�lasyonu i�lemini ger�ekle�tirin
            for (double t = t1; t <= t2; t += ta)
            {
                // Frekans mod�lasyonu i�lemi
                double v = Math.Sin(wt * t + m * Math.Sin(wb * t));

                // Olu�turulan veri noktalar�n� grafi�e ekleyin
                series.Points.AddXY(t, v);
            }

            // Grafi�i forma ekleyin
            Controls.Add(chart);
        }
    }
}