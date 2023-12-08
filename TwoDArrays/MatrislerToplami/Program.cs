// girdi
Console.Write("N x N A ve B Matrisleri icin \nN degeri: ");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrisA = new int[n,n];
int[,] matrisB = new int[n, n];
int[,] matrisC = new int[n,n];
// sutun
for (int i = 0; i < n; i++)
{
    // satir
	for (int j = 0; j < n; j++)
    {
        Console.Write($"A ({i+1}, {j+1}):");
        matrisA[i,j] = int.Parse(Console.ReadLine());
        Console.Write($"B ({i+1},{j+1}):");
        matrisB[i,j] = int.Parse(Console.ReadLine());
        matrisC[i,j] = matrisA[i,j] + matrisB[i,j];
    }
}
Console.WriteLine("Matrislerin Toplami");
// sutun
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
        Console.Write($"{matrisC[i, j]} \t");
    // yeni satira gec
    Console.WriteLine();
}
