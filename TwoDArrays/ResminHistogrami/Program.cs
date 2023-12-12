using System.Drawing;
// Kullanıcıdan resmin yolunu al
Console.Write("Resmin yolunu giriniz: ");
string imagePath = Console.ReadLine();

// Resmi belirtilen yol üzerinden yükle
using (Bitmap image = new Bitmap(imagePath))
{
    // Histogram için 256 elemanlı bir dizi oluştur
    int[] histogram = new int[256];

    // Resmi tarayarak histogramı oluştur
    for (int x = 0; x < image.Width; x++)
    {
        for (int y = 0; y < image.Height; y++)
        {
            // Piksel rengini al
            Color pixelColor = image.GetPixel(x, y);

            // Gri seviye değerini RGB bileşenlerine göre hesapla
            int greyValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

            // Histogram dizisinde ilgili gri değerine sahip elemanı artır
            histogram[greyValue]++;
        }
    }

    // Histogramı ekrana yazdır
    for (int i = 0; i < 256; i++)
    {
        Console.WriteLine($"Grilik {i} : Histogram {histogram[i]} piksel");
    }
}