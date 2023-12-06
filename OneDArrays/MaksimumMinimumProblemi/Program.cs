// n elemanli dizinin en buyuk ve en kucuk elemanini bul
Console.Write("Dizinin eleman sayisi: ");
int n = int.Parse(Console.ReadLine());
// dizi tanimla
int[] array = new int[n];
// dizin elemanlarini al
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i+1}. Eleman: ");
    array[i] = int.Parse(Console.ReadLine());
}
// degisken tanimlama ve ilk deger
int enb = array[0], enk = array[0], enbyer = 1, enkyer = 1;
// karsilastirma islemlerinin yapildigi dongu
for (int i = 1; i < array.Length; i++)
{
    // yeni deger buyukse enb olarak ata ve yerini bildir
    if (array[i] > enb)
    {
        enb = array[i];
        enbyer = i;
    }
    // yeni deger kucukse enk olarak ata ve yerini bildir
    if (array[i] < enk)
    {
        enk = array[i];
        enkyer = i;
    }
}
// cikti
Console.WriteLine($"En kucuk Eleman: {enk} \t {enkyer}.indekste \nEn buyuk eleman: {enb} \t {enbyer}.indekste");

