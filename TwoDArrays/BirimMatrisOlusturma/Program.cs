// girdi
Console.Write("Birim matrisin tipini giriniz:");
int n = int.Parse(Console.ReadLine());
int[,] matris = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
	for (int j = 0; j < n; j++)
    {
        // ana kosegen uzerinde ise 1 ata, degilse 0 ata
        matris[i, j] = (i == j) ? 1 : 0;
        Console.Write($"{matris[i, j]}\t");
    }
    // yeni satira gec
    Console.WriteLine();
}