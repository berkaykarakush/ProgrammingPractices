using System.Drawing;
using System.Drawing.Imaging;

// Kullanıcıdan resmin yolunu alınır.
Console.Write("Resmin yolunu giriniz: ");
string imagePath = Console.ReadLine();

// Kullanıcıdan gama değerini alınır.
Console.Write("G degerini giriniz: ");
int gama = int.Parse(Console.ReadLine());

// Belirtilen resim yolundan bir Bitmap nesnesi oluşturulur.
using (Bitmap image = new Bitmap(imagePath))
{
    // Sonuç resmi için boş bir Bitmap nesnesi oluşturulur.
    Bitmap resultImage = new Bitmap(image.Width, image.Height);

    // Her piksel için iç içe döngü oluşturulur.
    for (int x = 0; x < image.Width; x++)
    {
        for (int y = 0; y < image.Height; y++)
        {
            // Mevcut pikselin rengi alınır.
            Color pixelColor = image.GetPixel(x, y);

            // Gama düzeltme formülüne göre her renk kanalı için yeni değer hesaplanır.
            int r = (int)(255 * Math.Pow(pixelColor.R / 255.0, gama));
            int g = (int)(255 * Math.Pow(pixelColor.G / 255.0, gama));
            int b = (int)(255 * Math.Pow(pixelColor.B / 255.0, gama));

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
    string resultImagePath = Path.Combine(directory, $"{fileNameWithoutExtension}_gama{extension}");

    // Yeni resim belirtilen formatta kaydedilir.
    resultImage.Save(resultImagePath, ImageFormat.Png);

    // Kullanıcıya işlemin tamamlandığı ve yeni resmin yolunu gösteren bir mesaj yazdırılır.
    Console.WriteLine($"Islem tamamlandi {resultImagePath}");
}