// girdi
Console.Write("N x N, N degeri: ");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matris = new int[n, n];
// tum degerler default olarak 9 gelmektedir
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
        Console.Write($"{matris[i, j]}\t");
    // yeni satira gec
    Console.WriteLine();
}
