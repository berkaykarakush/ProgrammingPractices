// Kullanıcıdan X koordinatını girmesini iste
Console.Write("X koordinatını giriniz: ");
double pixelX = double.Parse(Console.ReadLine());

// Kullanıcıdan Y koordinatını girmesini iste
Console.Write("Y koordinatını giriniz: ");
double pixelY = double.Parse(Console.ReadLine());

// Kullanıcıdan döndürme açısını girmesini iste
Console.Write("Döndürme açısını giriniz (derece):");
double angle = double.Parse(Console.ReadLine());

// Dereceyi radyana çevir
double radians = angle * Math.PI / 180;

// Döndürme matrisini oluştur
double[,] rotationMatrix = {
    { Math.Cos(radians), -Math.Sin(radians) },
    { Math.Sin(radians), Math.Cos(radians) }
};

// Döndürme işlemi: X ve Y koordinatlarını matrisle çarp
double rotatedX = pixelX * rotationMatrix[0, 0] + pixelY * rotationMatrix[0, 1];
double rotatedY = pixelX * rotationMatrix[1, 0] + pixelY * rotationMatrix[1, 1];

// Sonuçları ekrana yazdır
Console.WriteLine($"Eski Nokta: ({pixelX},{pixelY})");
Console.WriteLine($"Yeni Nokta: ({rotatedX},{rotatedY})");
