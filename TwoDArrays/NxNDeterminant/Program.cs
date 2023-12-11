// girdi
Console.Write("N x N matrisi icin N degeri: ");
int n =int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
	// sutun
	for (int j = 0; j < n; j++)
	{
        // degerleri al
        Console.Write($"N({i+1},{j+1}): ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
// baslangic degeri
double d = 1;
// gecici matris tanimla
int[,] matrixB = new int[n, n];
// Gauss eleme yontemi ile determinant hesapla
for (int k = 0; k < n - 2; k++)
{
    // diger satirlardaki elemanlari sifirla
	d = d / (Math.Pow(matrix[0, 0], n - k - 2));

	for (int i = 0; i < n - k - 1; i++)
        for (int j = 0; j < n - k - 1; j++)
            matrixB[i, j] = matrix[0, 0] * matrix[i+1, j+1] - matrix[0, j+1] * matrix[i+1, 0];

    // gecici matris ana matris olarak guncelle
	for (int i = 0; i < n - k - 1; i++)
        for (int j = 0; j < n - k - 1; j++)
            matrix[i, j] = matrixB[i, j];
}
// determinanti tamamlamak icin kalan iki elemani carp
d = d * (matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0]);
// cikti
Console.WriteLine($"Determinant: {d:F3}");
