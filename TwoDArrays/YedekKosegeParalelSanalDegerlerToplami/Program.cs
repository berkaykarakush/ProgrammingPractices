// girdi
Console.Write("N x N Matrisi icin N degeri:");
int n = int.Parse(Console.ReadLine());
// n x n matris tanimlama
int[,] matrix = new int[n, n];
// satir
for (int i = 0; i < n; i++)
{
    // sutun
    for (int j = 0; j < n; j++)
    {
        // 1-10 arasi deger ata
        matrix[i,j] = new Random().Next(1,10);
        Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}
// yedek kosegene paralel sanal kosegenler uzerindeki eleman sayisini tutacak dizi olusturuldu
int[] array = new int[n * 2 - 1];
// dizinin icinde don
for (int i = 0; i < array.Length;i++)
{
    // satir
    for (int j = 0; j < n; j++)
    {
        // sutun
        for (int k = 0; k < n; k++)
        {
            // dizi indisi toplanan matris elemanlarin indisleri toplamindan bir eksiktir yani array[1] icin 2 seklinde
            if (j+k==i)
                array[i] += matrix[j, k];
        }
    }
}
int low = array[0], high = array[0];
// en kucuk ve en buyuk deger icin dizi icerisinde don
for (int i = 1; i < n; i++)
{
    // en kucuk deger yeni degerden buyukse en kucuk degeri guncelle
    if (array[i] < low)
        low = array[i];
    // en buyuk deger yeni gelen degerden kucukse en buyuk degeri guncelle
    if (array[i] > high)
        high = array[i];
}
// cikti
Console.WriteLine($"En Kucuk Deger: {low} \nEn Buyuk Deger: {high}");