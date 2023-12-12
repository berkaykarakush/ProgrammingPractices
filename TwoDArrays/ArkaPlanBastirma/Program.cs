using System.Drawing;

// Kullanıcıdan birinci resmin yolunu al
Console.WriteLine("1. Resmin yolunu giriniz: ");
string firstImagePath = Console.ReadLine();

// Kullanıcıdan ikinci resmin yolunu al
Console.Write("2. Resmin yolunu giriniz: ");
string secondImagePath = Console.ReadLine();

// Birinci resmi aç
using (Bitmap firstImage = new Bitmap(firstImagePath))
{
    // İkinci resmi aç
    using (Bitmap secondImage = new Bitmap(secondImagePath))
    {
        // Grafik nesnesi oluştur, bu nesne üzerine çizim yapılacak
        using (Graphics g = Graphics.FromImage(firstImage))
        {
            // İkinci resmin çözünürlüğünü birinci resmin çözünürlüğüne ayarla
            secondImage.SetResolution(firstImage.HorizontalResolution, firstImage.VerticalResolution);

            // İkinci resmi birinci resmin üzerine çiz
            g.DrawImage(secondImage, new Rectangle(0, 0, firstImage.Width, firstImage.Height), new Rectangle(0, 0, secondImage.Width, secondImage.Height), GraphicsUnit.Pixel);

            // Yeni resmi kaydet
            string directory = Path.GetDirectoryName(firstImagePath);
            string fileNameWithoutExtensionName = Path.GetFileNameWithoutExtension(firstImagePath);
            string extension = Path.GetExtension(firstImagePath);
            string resultImagePath = Path.Combine(directory, $"{fileNameWithoutExtensionName}_damping{extension}");
            firstImage.Save(resultImagePath);

            Console.WriteLine($"İşlem başarıyla tamamlandı. Yeni resim: {resultImagePath}");
        }
    }
}
