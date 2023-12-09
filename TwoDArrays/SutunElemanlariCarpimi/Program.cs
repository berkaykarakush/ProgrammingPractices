// girdi
Console.Write("N x N matrisi icin N degeri: ");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n,n];
// dizi tanimla
int[] array = new int[n];
int multiply = 1;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
	for (int j = 0; j < n; j++)
	{
        // elemanlari al
        Console.Write($"N({i+1},{j+1}):");
        matrix[i,j] = int.Parse(Console.ReadLine());
    }
}
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // ayni sutunda olan degerlerin sutun degerleri ayni olacaktir, degisen satir degerleri olacaktir
        multiply = multiply * matrix[j, i];
        array[i] = multiply;
    }
    // deger diziye atandiktan sonra sifirla
    multiply = 1;
}
// cikti
Console.WriteLine("Carpim");
for (int i = 0;i < n; i++)
    Console.WriteLine($"{array[i]}");    