using System.Drawing;
using System.Drawing.Imaging;

// Kullanıcıdan resmin yolunu al
Console.Write("Resmin yolunu giriniz:");
string imagePath = Console.ReadLine();

// Kullanıcıdan eşik değeri al
Console.Write("Eşik değeri: ");
int threshold = int.Parse(Console.ReadLine());

// Resmi aç
using (Bitmap image = new Bitmap(imagePath))
{
    // Sonuç resmini oluştur
    using (Bitmap resultImage = new Bitmap(image.Width, image.Height))
    {
        // Her piksel üzerinde dolaş
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                // Pikselin renk değerlerini al
                Color pixelColor = image.GetPixel(x, y);
                int pixelValue = pixelColor.R + pixelColor.G + pixelColor.B;

                // Eşik değeri kontrolü
                Color newColor = pixelValue < threshold * 3 ? Color.Black : pixelColor;

                // Sonuç resmine pikseli yerleştir
                resultImage.SetPixel(x, y, newColor);
            }
        }

        // Sonuç resmini kaydet
        string directory = Path.GetDirectoryName(imagePath);
        string fileNameWithoutExtensionName = Path.GetFileNameWithoutExtension(imagePath);
        string extension = Path.GetExtension(imagePath);
        string resultImagePath = Path.Combine(directory, $"{fileNameWithoutExtensionName}_threshold{extension}");
        resultImage.Save(resultImagePath, ImageFormat.Jpeg);

        // İşlem tamamlandı mesajı
        Console.WriteLine($"İşlem tamamlandı. Yeni resim: {resultImagePath}");
    }
}