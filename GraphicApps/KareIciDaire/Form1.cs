namespace KareIciDaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklenirken tetiklenen olay.
            // Bu olayda bir PictureBox kontrolü oluþturuluyor ve formun kontrol listesine ekleniyor.
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Width = 300;
            pictureBox1.Height = 300;
            pictureBox1.Paint += pictureBox1_Paint; // PictureBox kontrolüne Paint olayýný baðla.
            this.Controls.Add(pictureBox1); // PictureBox kontrolünü formun kontrol listesine ekle.
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // PictureBox kontrolünün Paint olayý tetiklendiðinde gerçekleþen çizim iþlemleri.

            // Kara dikdörtgen çizimi (sol üst köþesi (50, 50), geniþlik 200, yükseklik 200).
            e.Graphics.DrawRectangle(Pens.Black, 50, 50, 200, 200);

            // Kýrmýzý elips çizimi (sol üst köþesi (75, 75), geniþlik 150, yükseklik 150).
            e.Graphics.DrawEllipse(Pens.Red, 75, 75, 150, 150);
        }
    }
}
