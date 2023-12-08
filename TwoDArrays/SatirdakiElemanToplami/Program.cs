// girdi
Console.Write("NxN Matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matris = new int[n, n];
int result = 0; 
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlari al ve ata
        Console.Write($"N({i + 1},{j + 1}):");
        matris[i, j] = int.Parse(Console.ReadLine());
        // 2. satirdaki elemalar icin
        if (i == 1)
            // topla
            result += matris[i, j];
    }
}
Console.WriteLine($"2. satirdaki elemanlarin toplami: {result}");
