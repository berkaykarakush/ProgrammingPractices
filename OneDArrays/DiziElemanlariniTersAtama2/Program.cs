// dizi elemanlarini baska dizi kullanmadan tersten yazdirma
Console.Write("Dizinin eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// n elemanli dizi tanimla
int[] array = new int[n];
// dizinin elemanlarini al
for (int i = 0; i < n; i++)
{
    Console.Write($"{i+1}.Eleman: ");
    array[i] = int.Parse(Console.ReadLine());
}
// diziyi ters cevir
for (int i = 0; i < n / 2; i++)
{
    int r = array[i];
    array[i] = array[n-1-i];
    array[n - 1 - i] = r;
}
// tersten cikti
for (int i = 0; i < n; i++)
    Console.WriteLine($"{i+1}.Eleman: {array[i]}");

