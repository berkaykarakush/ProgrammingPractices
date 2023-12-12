using System.Drawing;
using System.Drawing.Imaging;
// Kullanıcıdan resmin yolunu alınır.
Console.Write("Resmin yolunu giriniz: ");
string imagePath = Console.ReadLine();

// Kullanıcıdan istenen kontrast seviyesini alınır.
Console.Write("Istenilen C kontrast seviyesi: ");
double c = double.Parse(Console.ReadLine());

// Kontrast formülüne göre gerekli hesaplamalar yapılır.
double f = (259 * (c + 255)) / (255 * (255 - c));

// Belirtilen resim yolundan bir Bitmap nesnesi oluşturulur.
using (Bitmap image = new Bitmap(imagePath))
{
    // Sonuç resmi için boş bir Bitmap nesnesi oluşturulur.
    Bitmap resultImage = new Bitmap(image.Width, image.Height);

    // Her piksel için döngü oluşturulur.
    for (int x = 0; x < image.Width; x++)
    {
        for (int y = 0; y < image.Height; y++)
        {
            // Mevcut pikselin rengi alınır.
            Color pixelColor = image.GetPixel(x, y);

            // Kontrast formülüne göre her renk kanalı için yeni değer hesaplanır.
            int r = (int)Math.Min(255, Math.Max(0, (f * (pixelColor.R - 128) + 128)));
            int g = (int)Math.Min(255, Math.Max(0, (f * (pixelColor.G - 128) + 128)));
            int b = (int)Math.Min(255, Math.Max(0, (f * (pixelColor.B - 128) + 128)));

            // Yeni renk değerleri ile yeni bir renk oluşturulur.
            Color newColor = Color.FromArgb(r, g, b);

            // Sonuç resmindeki piksel, yeni renk değeri ile güncellenir.
            resultImage.SetPixel(x, y, newColor);
        }
    }

    // Yeni resmin kaydedileceği dizin ve dosya adı oluşturulur.
    string directory = Path.GetDirectoryName(imagePath);
    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imagePath);
    string extension = Path.GetExtension(imagePath);
    string resultImagePath = Path.Combine(directory, $"{fileNameWithoutExtension}_autocontrast{extension}");

    // Yeni resim belirtilen formatta kaydedilir.
    resultImage.Save(resultImagePath, ImageFormat.Png);

    // Kullanıcıya işlemin tamamlandığı ve yeni resmin yolunu gösteren bir mesaj yazdırılır.
    Console.WriteLine($"Islem tamamlandi {resultImagePath}");
}