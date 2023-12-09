// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimlama
int[,] matrix = new int[n, n];
int[] array = new int[n * n];
// satir
int k = 0;
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // elemanlari al
        Console.Write($"N({i+1},{j+1}): ");
        matrix[i, j] = int.Parse(Console.ReadLine());
        // her elemani diziye ata
        array[k] = matrix[i, j];
        // dizinin indis degerini arttir
        k++;
    }
}
// kucukten buyuge sirala
Array.Sort(array);
// satir
for (int i = 0; i < n * n; i++)
    // cikti
    Console.Write($"{array[i]}\t");
