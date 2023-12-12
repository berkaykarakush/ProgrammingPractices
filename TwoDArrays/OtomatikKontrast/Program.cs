using System.Drawing;
using System.Drawing.Imaging;
// Kullanıcıdan resmin dosya yolunu al
Console.Write("Resmin yolunu giriniz: ");
string imagePath = Console.ReadLine();

// Resmi belirtilen yol üzerinden yükle
using (Bitmap image = new Bitmap(imagePath))
{
    // Yeni bir resim oluştur, orijinal resmin boyutlarına sahip
    Bitmap resultImage = new Bitmap(image.Width, image.Height);

    // En parlak ve en koyu piksel değerlerini başlangıç değerleriyle ayarla
    int pmin = 0; // en parlak piksel değeri
    int pmax = 255; // en koyu piksel değeri

    // Orijinal resmin en parlak ve en koyu piksel değerlerini bul
    for (int x = 0; x < image.Width; x++)
    {
        for (int y = 0; y < image.Height; y++)
        {
            // Her pikselin gri değerini hesapla
            Color pixelColor = image.GetPixel(x, y);
            int greyValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

            // En parlak ve en koyu piksel değerlerini güncelle
            pmax = Math.Max(pmax, greyValue);
            pmin = Math.Min(pmin, greyValue);
        }
    }

    // Orijinal resmin her pikselini döngü içinde tekrar tarayarak kontrastı ayarla
    for (int x = 0; x < image.Width; x++)
    {
        for (int y = 0; y < image.Height; y++)
        {
            // Her pikselin gri değerini hesapla
            Color pixelColor = image.GetPixel(x, y);
            int greyValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

            // Yeni gri değeri hesapla ve uygula
            int newGreyValue = (int)((greyValue - pmin) * 255.0 / (pmax - pmin));
            Color newColor = Color.FromArgb(newGreyValue, newGreyValue, newGreyValue);

            // Yeni piksel değerini resultImage üzerine uygula
            resultImage.SetPixel(x, y, newColor);
        }
    }

    // Yeni resmin kaydedileceği yol ve adı
    string directory = System.IO.Path.GetDirectoryName(imagePath);
    string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(imagePath);
    string extension = System.IO.Path.GetExtension(imagePath);
    string resultImagePath = System.IO.Path.Combine(directory, $"{fileNameWithoutExtension}_contrast{extension}");

    // Yeni resmi PNG formatında kaydet
    resultImage.Save(resultImagePath, ImageFormat.Png);

    // İşlem tamamlandı mesajını ekrana yazdır
    Console.WriteLine($"İşlem tamamlandı. Yeni resmin yolu: {resultImagePath}");
}
