// girdi
Console.Write("N x N matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimla
int[,] matrix = new int[n, n];
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
int le = matrix[n - n, n - n], se = matrix[n - n, n - n], lr = 0, lc = 0, sr = 0, sc = 0;
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // en buyuk eleman
        if (matrix[i, j] > le)
        {
            // eleman
            le = matrix[i, j];
            // satir degeri
            lr = i;
            // sutun degeri
            lc = j;
        }
        // en kucuk eleman
        if (matrix[i, j] < se)
        {
            // eleman
            se = matrix[i, j];
            // satir degeri
            sc = i;
            // sutun degeri
            sr = j;
        }
    }
}
Console.Write($"En buyuk eleman: {le} \t En buyuk eleman satir: {lr} \t En buyuk eleman sutun: {lc} \nEn kucuk eleman: {se} \t En kucuk eleman satir: {sr} \t En kucuk eleman sutun: {sc}");