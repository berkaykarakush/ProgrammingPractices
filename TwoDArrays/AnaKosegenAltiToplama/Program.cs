// girdi
Console.Write("N x N Matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimlama
int[,] matris = new int[n, n];
int result = 0;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i+1},{j+1}):");
        matris[i, j] = int.Parse(Console.ReadLine());
        // ana kosegen altinda kalanlar satir degeri sutun degerinden kucuk olanlardir yani j < i
        if (j < i)
            result += matris[i, j];
    }
}
// sonuc
Console.WriteLine($"Result: {result}");
