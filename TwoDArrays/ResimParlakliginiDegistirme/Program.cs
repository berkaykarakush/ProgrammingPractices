using System.Drawing;
using System.Drawing.Imaging;

// Kullanıcıdan resmin dosya yolunu al
Console.Write("Resmin yolunu giriniz: ");
string originalPath = Console.ReadLine();

// Kullanıcıdan parlaklık değerini al
Console.Write("Parlaklik Degerini giriniz: ");
int value = int.Parse(Console.ReadLine());

// Orijinal resmi yükle
using (Bitmap originalImage = new Bitmap(originalPath))
{
    // Ayarlanmış resim için yeni bir Bitmap oluştur
    using (Bitmap adjustedImage = new Bitmap(originalImage.Width, originalImage.Height))
    {
        // Her bir pikseli döngü içinde gez
        for (int x = 0; x < originalImage.Width; x++)
        {
            for (int y = 0; y < originalImage.Height; y++)
            {
                // Orijinal pikselin renk değerlerini al
                Color originalColor = originalImage.GetPixel(x, y);

                // Yeni parlaklık değerini ekleyerek sınırla (0-255 arasında olmalı)
                int originalImageRed = Math.Max(0, Math.Min(originalColor.R + value, 255));
                int originalImageGreen = Math.Max(0, Math.Min(originalColor.G + value, 255));
                int originalImageBlue = Math.Max(0, Math.Min(originalColor.B + value, 255));

                // Yeni renk değerleriyle bir renk oluştur
                Color adjustedColor = Color.FromArgb(originalImageRed, originalImageGreen, originalImageBlue);

                // Ayarlanmış resimdeki pikseli güncelle
                adjustedImage.SetPixel(x, y, adjustedColor);
            }
        }

        // Ayarlanmış resmin kaydedileceği dosya yolu ve adını oluştur
        string directory = Path.GetDirectoryName(originalPath);
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(originalPath);
        string extension = Path.GetExtension(originalPath);
        string adjustedImagePath = Path.Combine(directory, $"{fileNameWithoutExtension}_brightness_{value}{extension}");

        // Ayarlanmış resmi kaydet
        adjustedImage.Save(adjustedImagePath, ImageFormat.Png);

        // Kullanıcıya işlemin tamamlandığı bilgisini göster
        Console.WriteLine($"Islem tamamlandi: {adjustedImagePath}");
    }
}