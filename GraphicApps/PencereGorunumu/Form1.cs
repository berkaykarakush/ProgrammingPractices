namespace PencereGorunumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Paint olayýna çizim kodunu ekleyin
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Çizim iþlemlerini gerçekleþtiren metot

            // Siyah renkte, 3 piksel kalýnlýðýnda bir kalem oluþturun
            Pen line = new Pen(Color.Black, 3);

            // Eliptik bir þekil çizin (x, y, geniþlik, yükseklik)
            e.Graphics.DrawEllipse(line, 120, 120, 160, 160);

            // Dikdörtgen bir þekil çizin (x, y, geniþlik, yükseklik)
            e.Graphics.DrawRectangle(line, 120, 120, 160, 160);

            // Ýki nokta arasýnda bir çizgi çizin (x1, y1, x2, y2)
            e.Graphics.DrawLine(line, 120, 200, 280, 200);
            e.Graphics.DrawLine(line, 200, 120, 200, 280);

            // Kullanýlan kaynaklarý serbest býrakýn
            line.Dispose();
        }
    }
}
