using System.Drawing;

// Kullanıcıdan 1. resmin dosya yolunu al
Console.Write("1. Resmin yolunu giriniz: ");
string firstImagePath = Console.ReadLine();

// Kullanıcıdan 2. resmin dosya yolunu al
Console.Write("2. Resmin yolunu giriniz: ");
string secondImagePath = Console.ReadLine();

// 1. Resmi yükle
using (Bitmap firstImage = new Bitmap(firstImagePath))
{
    // 1. Resmin genişliği ve yüksekliği
    int firstWidth = firstImage.Width;
    int firstHeight = firstImage.Height;

    // Her bir RGB bileşenini içeren bir matris oluştur
    int[,,] firstImageMatrix = new int[firstWidth, firstHeight, 3];

    // 2. Resmi yükle
    using (Bitmap secondImage = new Bitmap(secondImagePath))
    {
        // 2. Resmin genişliği ve yüksekliği
        int secondWidth = secondImage.Width;
        int secondHeight = secondImage.Height;

        // Her bir RGB bileşenini içeren bir matris oluştur
        int[,,] secondImageMatrix = new int[secondWidth, secondHeight, 3];

        // Çarpım sonucunu tutacak matris
        int[,,] thirdImageMatrix = new int[firstWidth, firstHeight, 3];

        // Her bir pikseli işle
        for (int x = 0; x < firstImage.Width; x++)
        {
            for (int y = 0; y < firstImage.Height; y++)
            {
                // 1. Resmin piksel renk bilgisini al
                Color firstPixelColor = firstImage.GetPixel(x, y);
                firstImageMatrix[x, y, 0] = firstPixelColor.R; // Kırmızı bileşen
                firstImageMatrix[x, y, 1] = firstPixelColor.G; // Yeşil bileşen
                firstImageMatrix[x, y, 2] = firstPixelColor.B; // Mavi bileşen

                // 2. Resmin piksel renk bilgisini al
                Color secondPixelColor = secondImage.GetPixel(x, y);
                secondImageMatrix[x, y, 0] = secondPixelColor.R; // Kırmızı bileşen
                secondImageMatrix[x, y, 1] = secondPixelColor.G; // Yeşil bileşen
                secondImageMatrix[x, y, 2] = secondPixelColor.B; // Mavi bileşen

                // Elementer çarpma işlemi
                thirdImageMatrix[x, y, 0] = firstImageMatrix[x, y, 0] * secondImageMatrix[x, y, 0];
                thirdImageMatrix[x, y, 1] = firstImageMatrix[x, y, 1] * secondImageMatrix[x, y, 1];
                thirdImageMatrix[x, y, 2] = firstImageMatrix[x, y, 2] * secondImageMatrix[x, y, 2];
            }
        }

        // Yeni bir resim oluştur
        using (Bitmap resultImage = new Bitmap(firstWidth, firstHeight))
        {
            // Her bir pikseli işle
            for (int x = 0; x < firstWidth; x++)
            {
                for (int y = 0; y < firstHeight; y++)
                {
                    // Yeni piksel renk değerlerini belirle ve sınırla
                    Color resultPixelColor = Color.FromArgb(
                        Math.Min(thirdImageMatrix[x, y, 0], 255), // Kırmızı bileşen
                        Math.Min(thirdImageMatrix[x, y, 1], 255), // Yeşil bileşen
                        Math.Min(thirdImageMatrix[x, y, 2], 255)  // Mavi bileşen
                    );

                    // Yeni pikseli resme ekle
                    resultImage.SetPixel(x, y, resultPixelColor);
                }
            }

            // Yeni resmi kaydet
            string directory = Path.GetDirectoryName(firstImagePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(firstImagePath);
            string extension = Path.GetExtension(firstImagePath);
            string resultImagePath = Path.Combine(directory, $"{fileNameWithoutExtension}_result{extension}");
            resultImage.Save(resultImagePath);
            Console.WriteLine($"Resim kaydedildi. {resultImagePath}");
        }
    }
}