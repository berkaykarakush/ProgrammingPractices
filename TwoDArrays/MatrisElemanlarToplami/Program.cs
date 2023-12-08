// girdi
Console.Write("N x N matrisi icin N degeri:");
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
		// elemanlari al
		Console.Write($"N({i + 1},{j + 1}):");
		matris[i, j] = int.Parse(Console.ReadLine());
		// her elemani topla
		result += matris[i, j];
	}
}
// cikti
Console.WriteLine($"Toplam: {result}");
