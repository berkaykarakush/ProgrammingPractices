// girdi
int n = 2;
// 2 x 2 matris
double[,] matrix = new double[n, n];
double[,] reverse = new double[n, n];
// satir
for (int i = 0; i < n; i++)
{
	// sutun
	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = new Random().Next(1,10);
		Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}
// determinant hesaplama
double dt = matrix[0,0] * matrix[1,1] - matrix[0,1]*matrix[1,0];
// tersini alma islemi
reverse[0, 0] = matrix[1, 1] / dt;
reverse[0, 1] = -matrix[0, 1] / dt;
reverse[1, 0] = -matrix[1, 0] / dt;
reverse[1, 1] = matrix[0, 0] / dt;
// cikti
Console.WriteLine($"{dt} \n{reverse[0,0]} \n{reverse[0,1]} \n{reverse[1,0]} \n{reverse[1,1]}");