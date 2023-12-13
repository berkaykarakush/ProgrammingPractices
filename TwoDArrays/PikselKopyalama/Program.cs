using System.Drawing;
using System.Drawing.Imaging;

Console.Write("Resmin yolunu giriniz: ");
string imagePath = Console.ReadLine();

Console.Write("Zoom degeri: ");
int zoomValue = int.Parse(Console.ReadLine());

// Giriş resmini yükle
using (Bitmap image = new Bitmap(imagePath))
{
    // Büyütülmüş resmin boyutlarını hesapla
    int width = image.Width * zoomValue;
    int height = image.Height * zoomValue;

    // Yeni bir büyütülmüş resim oluştur
    using (Bitmap resultImage = new Bitmap(width, height))
    {
        // Her bir pikseli kopyala ve büyüt
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                // Giriş resmindeki orijinal rengi al
                Color originColor = image.GetPixel(x / zoomValue, y / zoomValue);

                // Yeni büyütülmüş resme orijinal rengi yerleştir
                resultImage.SetPixel(x, y, originColor);
            }
        }

        // Çıktı dosyanın kaydedileceği dizin ve adı oluştur
        string directory = Path.GetDirectoryName(imagePath);
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imagePath);
        string extension = Path.GetExtension(imagePath);
        string resultImagePath = Path.Combine(directory, $"{fileNameWithoutExtension}_zoom{extension}");

        // Büyütülmüş resmi kaydet
        resultImage.Save(resultImagePath, ImageFormat.Png);

        // Kullanıcıya işlemin tamamlandığı bilgisini göster
        Console.WriteLine($"İşlem tamamlandı. Yeni resim: {resultImagePath}");
    }
}