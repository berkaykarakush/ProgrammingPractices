// girdi
Console.Write("Matrisinin tipini giriniz :");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimlamasi
int[,] matris = new int[n,n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Matris ({i+1},{j+1}): ");
        matris[i, j] = int.Parse(Console.ReadLine());
    }
}
