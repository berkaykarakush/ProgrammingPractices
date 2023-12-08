// girdi
Console.Write("N x N icin N degeri:");
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
        // degerleri al
        Console.Write($"N({i + 1},{j + 1}):");
        matris[i,j] = int.Parse(Console.ReadLine());
        // ana kosegen uzerinde kalan elemanlarin satir indisi sutun indisinden kucuktur yani i < j
        if (i < j)
            result += matris[i, j];
    }
}
// cikti
Console.WriteLine($"Result = {result}");
