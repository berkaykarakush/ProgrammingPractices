//iki diziyi ucuncu dizi uzerine toplayan program

Console.Write("Dizilerin eleman sayisini giriniz: ");//bilgi metni
int elemanSayisi = int.Parse(Console.ReadLine());//eleman sayisini al

//1'nci dizi
int[] birinciDizi = new int[elemanSayisi]; //1'nci dizi tanim
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{i + 1}'nci eleman: ");
    birinciDizi[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("******************");
//2'nci dizi
int[] ikinciDizi = new int[elemanSayisi]; //2'nci dizi tanimlama
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{i + 1}'nci eleman: ");
    ikinciDizi[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("******************");
//3'ncu dizi
int[] ucuncuDizi = new int[elemanSayisi];
for (int i = 0; i < elemanSayisi; i++)
{
    ucuncuDizi[i] = birinciDizi[i] + ikinciDizi[i]; //iki dizi toplama
    Console.WriteLine($"A[{i+1}]+B[{i+1}] = {ucuncuDizi[i]}");
}