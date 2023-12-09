// girdi
Console.Write("N x N matrisi N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n, n];
int[,] matrixB = new int[n, n-1];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
	for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i + 1},{j + 1}):");
        matrix[i,j] = int.Parse(Console.ReadLine());
    }
}
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n - 1; j++)
    {
        // bir onceki satir ile bir sonraki sutun degerlerini carp tek sutuna indirge
        matrixB[i,j] = matrix[i,j] * matrix[i,j+1];
        // yaz
        Console.Write($"{matrixB[i,j]}\t");
    }
    // yeni satir
    Console.WriteLine();
}