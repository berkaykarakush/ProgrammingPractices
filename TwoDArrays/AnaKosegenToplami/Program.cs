// girdi
Console.Write("N x N icin N degeri: ");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimlama
int[,] matris = new int[n,n];
int result = 0;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        Console.Write($"N ({i+1},{j+1}):");
        matris[i, j] = int.Parse(Console.ReadLine());
        // eger 2,2 3,3 gibi ana kosegen ise topla
        if (i == j)
            result += matris[i, j];
    }
}
// cikti
Console.WriteLine($"Toplam: {result}");
