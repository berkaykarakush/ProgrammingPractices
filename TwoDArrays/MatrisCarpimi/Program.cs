// girdi
Console.Write("N x N icin N Degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimlama
int[,] matrisA = new int[n, n];
int[,] matrisB = new int[n, n];
int[,] matrisC = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
	for (int j = 0; j < n; j++)
	{
        // elemanlari al
        Console.Write($"A ({i+1},{j+1}): ");
        matrisA[i, j] = int.Parse(Console.ReadLine());
        Console.Write($"B ({i + 1},{j + 1}): ");
        matrisB[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Carpim");
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlar icinde dolas
        for (int k = 0; k < n; k++)
            matrisC[i, j] += matrisA[i, k] * matrisB[k, j];
        Console.Write($"{matrisC[i, j]}\t");
    }
    // yeni satir
    Console.WriteLine();
}
