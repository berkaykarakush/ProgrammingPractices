namespace IcIceDaireler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Paint olayýna çizim kodunu ekleyin
            this.Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Çizim iþlemlerini gerçekleþtiren metot

            // Siyah renkte, 3 piksel kalýnlýðýnda bir kalem oluþturun
            Pen line = new Pen(Color.Black, 3);

            // Dikdörtgen bir þekil çizin (x, y, geniþlik, yükseklik)
            e.Graphics.DrawRectangle(line, 200, 200, 100, 100);

            // Ýlk elipsi çizin (x, y, geniþlik, yükseklik)
            e.Graphics.DrawEllipse(line, 150, 200, 100, 100);

            // Ýkinci elipsi çizin (x, y, geniþlik, yükseklik)
            e.Graphics.DrawEllipse(line, 200, 200, 100, 100);

            // Üçüncü elipsi çizin (x, y, geniþlik, yükseklik)
            e.Graphics.DrawEllipse(line, 250, 200, 100, 100);

            // Kullanýlan kaynaklarý serbest býrakýn
            line.Dispose();
        }
    }
}