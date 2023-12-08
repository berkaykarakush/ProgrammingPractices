// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n, n];
int[,] matrixT = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i+1},{j+1}):");
        matrix[i, j] = int.Parse(Console.ReadLine());
        // ana kosegen ustunde kalanlar icin satir degeri sutun degerinden kucuk olmalidir
        matrixT[i,j] = i > j ? 0 : matrix[i,j];
    }
}
// satir
for (int i = 0; i < n; i++)
{
    // sutun degerleri
    for (int j = 0; j < n; j++)
        Console.Write($"{matrixT[i,j]}\t");
    // yeni satir
    Console.WriteLine();
}