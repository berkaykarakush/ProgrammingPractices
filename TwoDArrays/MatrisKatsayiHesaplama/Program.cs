// girdi
Console.Write("N x N Matris icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimlama
int[,] matrix = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // degerleri al
        Console.Write($"N({i + 1},{j + 1}): ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
// katsayi degiskenleri
int x = 0, y = 0, z = 0, w = 0, t = 0;
// satir
for (int i = 0; i < n; i++)
{
    // i==j durumlarini hesapla
    x += matrix[i, i];
    // i'nin n'den geriye dogru gittigi, j'nin ise 1'den n e dogru gittigi durumlari hesaplar
    y += matrix[i,n - 1 - i];
    // 2. indeksin sutun degerlerini hesaplar
    z += matrix[i, 2];
    // sutun
    for (int j = 0; j < n; j++)
    {
        // 2. satirin son degerini, 3.satirin son iki degerini, 3.satirin ise son 3 degerini hesaplar
        if (i+j > n+1)
            w += matrix[i, j];
        // 1. satirin son uc degerini, 2. satirin son iki degerini, 3. satirin ise son degerini hesaplar
        if (i<j)
            t += matrix[i,j];
    }
}
// katsayi degerlerini diziye ata
int[] values = { x,y,z,w,t};
// kucukten buyuge dogru sirala
Array.Sort(values);
Console.WriteLine("Kucukten Buyuge dogru");
for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine($"{values[i]}");
}