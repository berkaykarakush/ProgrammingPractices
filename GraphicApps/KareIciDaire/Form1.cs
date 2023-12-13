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
            // Form y�klenirken tetiklenen olay.
            // Bu olayda bir PictureBox kontrol� olu�turuluyor ve formun kontrol listesine ekleniyor.
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Width = 300;
            pictureBox1.Height = 300;
            pictureBox1.Paint += pictureBox1_Paint; // PictureBox kontrol�ne Paint olay�n� ba�la.
            this.Controls.Add(pictureBox1); // PictureBox kontrol�n� formun kontrol listesine ekle.
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // PictureBox kontrol�n�n Paint olay� tetiklendi�inde ger�ekle�en �izim i�lemleri.

            // Kara dikd�rtgen �izimi (sol �st k��esi (50, 50), geni�lik 200, y�kseklik 200).
            e.Graphics.DrawRectangle(Pens.Black, 50, 50, 200, 200);

            // K�rm�z� elips �izimi (sol �st k��esi (75, 75), geni�lik 150, y�kseklik 150).
            e.Graphics.DrawEllipse(Pens.Red, 75, 75, 150, 150);
        }
    }
}
