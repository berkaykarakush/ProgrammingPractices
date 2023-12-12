using System.Drawing;
using System.Drawing.Imaging;

// Kullanıcıdan 1. resmin dosya yolunu al
Console.Write("1. Resmin yolunu giriniz: ");
string firstImagePath = Console.ReadLine();

// Kullanıcıdan 2. resmin dosya yolunu al
Console.Write("2. Resmin yolunu giriniz: ");
string secondImagePath = Console.ReadLine();

try
{
    // İlk resmi yükle
    using (Bitmap firstImage = new Bitmap(firstImagePath))
    {
        // İkinci resmi yükle
        using (Bitmap secondImage = new Bitmap(secondImagePath))
        {
            // Fark resmi için yeni bir bitmap oluştur
            using (Bitmap differentImage = new Bitmap(firstImage.Width, firstImage.Height))
            {
                // Piksel piksel karşılaştır
                for (int x = 0; x < firstImage.Width; x++)
                {
                    for (int y = 0; y < firstImage.Height; y++)
                    {
                        // Her iki resmin aynı piksel koordinatındaki renk değerlerini al
                        Color firstColor = firstImage.GetPixel(x, y);
                        Color secondColor = secondImage.GetPixel(x, y);

                        // Pikseller arasındaki farkı kontrol et
                        if (firstColor != secondColor)
                        {
                            // Farklı pikseli fark resmine ekle
                            // Farklı pikseli kırmızı renkle işaretle
                            differentImage.SetPixel(x, y, Color.Red);
                        }
                    }
                }

                // Fark resmini kaydet
                string directory = System.IO.Path.GetDirectoryName(firstImagePath);
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(firstImagePath);
                string extension = System.IO.Path.GetExtension(firstImagePath);
                string differentImagePath = System.IO.Path.Combine(directory, $"{fileNameWithoutExtension}_difference{extension}");
                differentImage.Save(differentImagePath, ImageFormat.Png);

                Console.WriteLine($"Fark resmi başarıyla kaydedildi: {differentImagePath}");
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Hata: {ex.Message}");
}