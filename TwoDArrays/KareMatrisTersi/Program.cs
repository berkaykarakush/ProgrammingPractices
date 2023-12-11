// girdi
Console.Write("N x N Matris icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
double[,] matrix = new double[n, n];
double[,] reverse = new double[n, n];
// satir
for (int i = 0; i < n; i++)
{
	// sutun
	for (int j = 0; j < n; j++)
	{
        // matrisin elemanlarina 1-10 arasi rastgele degerler atanir
        Console.Write("ELeman: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
        //matrix[i, j] = new Random().Next(1,10);
		//Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}
// Gauss-Jordan eliminasyon yontemi kullanilarak matrisin tersi alinir
for (int k = 0; k < n; k++)
{
	// satir
	for (int i = 0; i < n; i++)
	{
		// sutun
		for (int j = 0; j < n; j++)
		{
			// diagonal eleman disindaki elemanlar guncellenir
			if (!((i == k) || (j == k)))
				matrix[i, j] -= matrix[i,k] * matrix[k,j] / matrix[k,k];
		}
	}
	// diagonal eleman guncellenir
	matrix[k, k] = -1 / matrix[k, k];
	// matrisin ust ucgen kismini guncelle
	for (int i = 0; i < n; i++)
	{
		if (i != k)
			matrix[i, k] *= matrix[k, k];
	}
	// matrisin alt ucgen kismi guncellenir
	for (int j = 0; j < n; j++)
	{
		if (j != k)
			matrix[k, j] *= matrix[k, k];
	}
}
// Ters matris olusturma ve ekrana yazdirma islemleri
// satir
for (int i = 0; i < n; i++)
{
	// sutun
	for (int j = 0; j < n; j++)
	{
		// tersini al
		reverse[i, j] = -matrix[i, j];
		// ekrana yaz
		Console.Write($"{reverse[i,j]:F3}\t");
    }
	// yeni satira gec
    Console.WriteLine();
}