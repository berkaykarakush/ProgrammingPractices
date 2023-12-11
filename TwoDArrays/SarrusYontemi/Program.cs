// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
	// sutun
	for (int j = 0; j < n; j++)
	{
        matrix[i,j] = new Random().Next(1,10);
        Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}
// 3 x 3 icin determinant
int d = matrix[0, 0]* matrix[1, 1]* matrix[2, 2] + 
        matrix[0, 1]* matrix[1, 2]* matrix[2, 0] + 
        matrix[0, 2]* matrix[1, 0]* matrix[2, 1] -
       (matrix[0, 2]* matrix[1, 1]* matrix[0, 0] +
        matrix[0, 0]* matrix[1, 2]* matrix[2, 1] +
        matrix[0, 1]* matrix[1, 0]* matrix[2, 2]);
// cikti
Console.WriteLine($"Determinant: {d}");