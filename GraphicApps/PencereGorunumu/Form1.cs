namespace PencereGorunumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Paint olay�na �izim kodunu ekleyin
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // �izim i�lemlerini ger�ekle�tiren metot

            // Siyah renkte, 3 piksel kal�nl���nda bir kalem olu�turun
            Pen line = new Pen(Color.Black, 3);

            // Eliptik bir �ekil �izin (x, y, geni�lik, y�kseklik)
            e.Graphics.DrawEllipse(line, 120, 120, 160, 160);

            // Dikd�rtgen bir �ekil �izin (x, y, geni�lik, y�kseklik)
            e.Graphics.DrawRectangle(line, 120, 120, 160, 160);

            // �ki nokta aras�nda bir �izgi �izin (x1, y1, x2, y2)
            e.Graphics.DrawLine(line, 120, 200, 280, 200);
            e.Graphics.DrawLine(line, 200, 120, 200, 280);

            // Kullan�lan kaynaklar� serbest b�rak�n
            line.Dispose();
        }
    }
}
