// dizinin eleman sayisi
Console.Write("Eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// n elemanli dizi olustur
int[] dizi = new int[n];
//tum elemanlara sifir degerini at
for (int i = 0; i < dizi.Length; i++)
    dizi[i] = 0;
//elemanlari yazdir
for (int i = 0;i<=dizi.Length;i++)
    Console.WriteLine($"{i}.Eleman : {dizi[i]}");
