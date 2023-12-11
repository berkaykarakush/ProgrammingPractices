// resmin genislik degerini al
Console.Write("Genislik: ");
int width = int.Parse(Console.ReadLine());
// resmin yukseklik degerini al
Console.Write("Yukseklik: ");
int height = int.Parse(Console.ReadLine());
// m x n matris tanimla
byte[,] matrix =  new byte[width, height];
// rastgele deger uretmek icin nesne olusturma
Random random = new Random();
// satir
for (int i = 0; i < height; i++)
{
	// sutun
	for (int j = 0; j < width; j++)
	{
		// her indise byte deger ata
		matrix[i, j] = (byte)random.Next(255);
		// siyahi beyaz, beyazi siyah yap
		matrix[i, j] = (byte)(255 - matrix[i, j]);
	}
}

// satir
for (int i = 0; i < height; i++)
{
	// sutun degerlerini yaz
	for (int j = 0; j < width; j++)
		Console.Write($"{matrix[i,j]}  ");
	// yeni satira gec
    Console.WriteLine();
}