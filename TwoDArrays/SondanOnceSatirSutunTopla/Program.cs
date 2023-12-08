// girdi
Console.Write("N x N icin N Degeri: ");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n, n];
// toplam degiskeni
int result = 0;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i+1},{j+1}):");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < n-1; i++)
    // sondan bir onceki sutun degerleri n = 4 icin 3 un degerlerini toplar
    result += matrix[i, n - 2] + matrix[n - 2, i];

// n-2,n-2 degeri iki kez islem goreceginden dolayi birini geri aliyoruz
result -= matrix[n-2, n-2];
Console.WriteLine($"Result: {result}");
