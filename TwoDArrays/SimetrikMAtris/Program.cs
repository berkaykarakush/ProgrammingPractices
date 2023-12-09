// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n,n];
bool result = true;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
	for (int j = 0; j < n; j++)
    {
        // degerleri al
        Console.Write($"N({i + 1},{j + 1}):");
        matrix[i,j] = int.Parse(Console.ReadLine());
    }
}
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // esil degilse kontrolu sonlandir
        if (matrix[i, j] != matrix[j, i])
        {
            result = false;
            break;
        }
    }
}
// dogru ise simetrik, degilse degil yaz
Console.WriteLine(result == true ? "Simetrik" : "Simetrik degildir");