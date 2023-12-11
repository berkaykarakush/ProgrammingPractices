// resmin genislik degerini al
Console.Write("r: ");
int r = int.Parse(Console.ReadLine());
// resmin yukseklik degerini al
Console.Write("g: ");
int g = int.Parse(Console.ReadLine());
// resmin renk degiskenini al
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
// m x n matris tanimla
byte[,,] matrix = new byte[r, g, b];
// rastgele deger uretmek icin nesne olusturma
Random random = new Random();
// Matrisin her bir elemanına rastgele değer atanıyor ve ardından negatif değeri alınıyor.
// satir
for (int i = 0; i < r; i++)
{
    // sutun
    for (int j = 0; j < g; j++)
    {
        // renk degiskeni
        for (int k = 0; k < b; k++)
        {
            // Matrisin her elemanına 0 ile 255 arasında rastgele bir değer atanıyor.
            matrix[i, j, k] = (byte)(random.Next(255));
            // Ardından bu değerin negatif değeri alınıyor.
            matrix[i, j, k] = (byte)(255 - matrix[i, j, k]);
        }
    }
}