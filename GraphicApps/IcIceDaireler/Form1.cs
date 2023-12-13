namespace IcIceDaireler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Paint olay�na �izim kodunu ekleyin
            this.Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // �izim i�lemlerini ger�ekle�tiren metot

            // Siyah renkte, 3 piksel kal�nl���nda bir kalem olu�turun
            Pen line = new Pen(Color.Black, 3);

            // Dikd�rtgen bir �ekil �izin (x, y, geni�lik, y�kseklik)
            e.Graphics.DrawRectangle(line, 200, 200, 100, 100);

            // �lk elipsi �izin (x, y, geni�lik, y�kseklik)
            e.Graphics.DrawEllipse(line, 150, 200, 100, 100);

            // �kinci elipsi �izin (x, y, geni�lik, y�kseklik)
            e.Graphics.DrawEllipse(line, 200, 200, 100, 100);

            // ���nc� elipsi �izin (x, y, geni�lik, y�kseklik)
            e.Graphics.DrawEllipse(line, 250, 200, 100, 100);

            // Kullan�lan kaynaklar� serbest b�rak�n
            line.Dispose();
        }
    }
}