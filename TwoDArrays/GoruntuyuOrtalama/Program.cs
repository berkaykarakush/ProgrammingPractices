using System.Drawing;
using System.Drawing.Imaging;

// Kullanıcıdan resim yolu ve zoom değeri alınır
Console.Write("Resmin yolunu giriniz: ");
string imagePath = Console.ReadLine();
Console.Write("Zoom degeri: ");
int zoomValue = int.Parse(Console.ReadLine());

// Giriş resmi yüklenir
using (Bitmap image = new Bitmap(imagePath))
{
    // Yeni resmin boyutları hesaplanır
    int width = image.Width * zoomValue;
    int height = image.Height * zoomValue;

    // Yeni bir resim oluşturulur
    using (Bitmap resultImage = new Bitmap(width, height))
    {
        // Her bir piksel için işlem yapılır
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // Yeni resimdeki koordinatları orijinal resim koordinatlarına dönüştürür
                float sourceX = x / (float)zoomValue;
                float sourceY = y / (float)zoomValue;

                // Orijinal resimdeki pikselin koordinatlarını belirler
                int x1 = (int)Math.Floor(sourceX);
                int x2 = (int)Math.Ceiling(sourceX);
                int y1 = (int)Math.Floor(sourceY);
                int y2 = (int)Math.Ceiling(sourceY);

                // Koordinatları kontrol eder ve sınırlar içinde tutar
                x1 = Math.Max(0, Math.Min(x1, image.Width - 1));
                x2 = Math.Max(0, Math.Min(x2, image.Width - 1));
                y1 = Math.Max(0, Math.Min(y1, image.Height - 1));
                y2 = Math.Max(0, Math.Min(y2, image.Height - 1));

                // Dört köşedeki piksellerin renklerini alır
                Color topLeft = image.GetPixel(x1, y1);
                Color topRight = image.GetPixel(x2, y1);
                Color bottomLeft = image.GetPixel(x1, y2);
                Color bottomRight = image.GetPixel(x2, y2);

                // Her bir renk bileşeni için interpolasyon yapar
                float xFraction = sourceX - x1;
                float yFraction = sourceY - y1;

                int red = (int)(topLeft.R * (1 - xFraction) * (1 - yFraction) +
                                topRight.R * xFraction * (1 - yFraction) +
                                bottomLeft.R * (1 - xFraction) * yFraction +
                                bottomRight.R * xFraction * yFraction);
                int green = (int)(topLeft.G * (1 - xFraction) * (1 - yFraction) +
                                topRight.G * xFraction * (1 - yFraction) +
                                bottomLeft.G * (1 - xFraction) * yFraction +
                                bottomRight.G * xFraction * yFraction);
                int blue = (int)(topLeft.B * (1 - xFraction) * (1 - yFraction) +
                                topRight.B * xFraction * (1 - yFraction) +
                                bottomLeft.B * (1 - xFraction) * yFraction +
                                bottomRight.B * xFraction * yFraction);

                // Interpolasyon sonucu oluşan rengi yeni resimdeki piksele atar
                Color interpolatedColor = Color.FromArgb(red, green, blue);
                resultImage.SetPixel(x, y, interpolatedColor);
            }
        }

        // Sonucun kaydedileceği dizin ve adı oluşturulur
        string directory = Path.GetDirectoryName(imagePath);
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imagePath);
        string extension = Path.GetExtension(imagePath);
        string resultImagePath = Path.Combine(directory, $"{fileNameWithoutExtension}_avg{extension}");

        // Yeni resmi kaydeder
        resultImage.Save(resultImagePath, ImageFormat.Png);

        // Kullanıcıya işlemin tamamlandığı bilgisini gösterir
        Console.WriteLine($"İşlem tamamlandı. Yeni resim: {resultImagePath}");
    }
}