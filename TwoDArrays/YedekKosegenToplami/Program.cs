// girdi
Console.Write("N x N Matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
int[,] matris = new int[n,n];
int result = 0;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // matris degerlerini al
        Console.Write($"N({i + 1},{j + 1}) = ");
        matris[i,j] = int.Parse(Console.ReadLine());
        //// yedek kosegen hesaplama yani n1, 33, 1n e dogur sol alt kosegenden sag ust koseye
        if (i + j == n - 1)
            result += matris[i, j];
    }
}
Console.WriteLine($"Sonuc: {result}");
