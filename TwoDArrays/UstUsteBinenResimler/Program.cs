using System.Drawing;
// girdi
Console.WriteLine("1. Resmin Dosya yolunu giriniz:");
string path1 = Console.ReadLine();
Console.WriteLine("2. Resmin Dosya yolunu giriniz:");
string path2 = Console.ReadLine();
// resmi yukle
using (Image image1 = Image.FromFile(path1))
{
    using (Image image2 = Image.FromFile(path2))
    {
        // Resmin boyutlarina gore bir Bitmap olustur
        using (Bitmap bitmap = new Bitmap(image1.Width, image1.Height))
        {
            // graphics nesnesi olustur
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // ilk resmi ciz
                g.DrawImage(image1, 0, 0);
                // ikinci resmi ustune ciz
                g.DrawImage(image2, 0, 0);
            }
            // Birlestirilmis resmi kaydetmek icin dosya yolu belirleme
            string bitmapPath = Path.Combine(Path.GetDirectoryName(path1),"combined-image.png");

            // birlestirilmis resmi kaydet
            bitmap.Save(bitmapPath);
            Console.WriteLine($"Resim basariyla kaydedilmistir. {bitmapPath}");
        }
    }
}
Console.WriteLine();