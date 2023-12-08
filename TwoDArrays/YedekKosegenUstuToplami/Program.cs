// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int result = 0;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
	for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i + 1},{j + 1}):");
        matrix[i,j] = int.Parse(Console.ReadLine());
        // yedek kosegen uzerinde kalan alanlarin indisleri toplami daima n-1'den kucuk olmaktadir
        if (i + j < n - 1)
            result += matrix[i, j];
    }
}
// cikti
Console.WriteLine($"Sonuc: {result}");