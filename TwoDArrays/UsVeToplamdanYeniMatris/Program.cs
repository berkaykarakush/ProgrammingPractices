// D = A^T + B.C dizisinin satir elemenlari toplamini E dizisine atayan program
// girdi
Console.WriteLine("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// matris tanimlama
int[,] matrixA = new int[n, n];
int[,] matrixB = new int[n, n];
int[,] matrixC = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
	// sutun
	for (int j = 0; j < n; j++)
	{
		// a matrisinin elemanlarini al
		Console.Write($"A ({i + 1},{j + 1}):");
		matrixA[i,j] = int.Parse(Console.ReadLine());	
		// b matrisinin elemanlarini al
		Console.Write($"B ({i + 1},{j + 1}):");
		matrixB[i,j] = int.Parse(Console.ReadLine());	
		// c matrisinin elemanlarini al
		Console.Write($"C ({i + 1},{j + 1}):");
		matrixC[i,j] = int.Parse(Console.ReadLine());	
	}
}
// n x n matrisleri tanimla
int[,] matrixD = new int[n, n];
int[,] matrixF= new int[n, n];
int[,] matrixG= new int[n, n];
// degerleri tutacagimiz dizi tanimlamasi
int[] array = new int[n];
// satir
for (int i = 0; i < n; i++)
{
	// sutun
    for (int j = 0; j < n; j++)
    {
		// a nin transpozesini al
        matrixF[i, j] = matrixA[j, i];
		// degeri sifirla
		matrixG[i, j] = 0;
		// b ve c matrislerini carp
		for (int k = 0; k < n; k++)
			matrixG[i, j] += matrixB[i, k] * matrixC[k, j];
		// transpoze islemi ve matris carpimlarini topla
		matrixD[i,j] = matrixF[i,j] + matrixG[i,j];
		// d matrisinin satir elemanlarini toplamindan array dizisini olustur, satir toplamini diziye ata
		array[i] += matrixD[i, j];
    }
}
// cikti
for (int i = 0; i < n; i++)
	Console.WriteLine($"{i+1}. Eleman: {array[i]}");