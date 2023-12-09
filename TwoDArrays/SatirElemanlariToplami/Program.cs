// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n, n];
int[] matrixR = new int[n];
// satir toplamlarini tutan degisken
int result = 0;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
	for (int j = 0; j < n; j++)
	{
        // elemanlari al
        Console.Write($"N({i+1},{j+1}):");
        matrix[i,j] = int.Parse(Console.ReadLine());
        result += matrix[i, j];
    }
    // yeni matris icine toplam degerlerini ata
    matrixR[i] = result;
    // her islem sonrasi toplam degiskeninin sifirlanmasi gerekmektedir
    result = 0;
}
// cikti
Console.WriteLine("Toplam");
for (int i = 0; i < n; i++)
    Console.WriteLine($"R({i}): {matrixR[i]}");