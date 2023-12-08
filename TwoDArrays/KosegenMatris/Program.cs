// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// matris tanimla
int[,] matrix = new int[n, n];
int[,] matrixC = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i+1},{j+1}):");
        matrix[i,j] = int.Parse(Console.ReadLine());
        // kosegen olmasi icin ana kosegen degerlerine ihtiyac vardir yani 1,0 2,0 3,0 seklinde
        if (i == j)
            matrixC[i, 0] = matrix[i, j];
    }
}
// satir degerleri
for (int i = 0; i < n; i++)
{
    // sutun degerleri
    for (int j = 0; j < n; j++)
        Console.Write($"{matrixC[i,j]}\t");
    // yeni satir
    Console.WriteLine();
}
