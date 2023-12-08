// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matris = new int[n, n];
int[,] matrisT = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i + 1},{j + 1}):");
        matris[i,j] = int.Parse(Console.ReadLine());
    } 
}
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // tersini al
        matrisT[i, j] = matris[j, i];
        Console.Write($"{matrisT[i,j]}\t");
    }
    // yeni satir
    Console.WriteLine();
}