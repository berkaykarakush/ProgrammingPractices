Console.WriteLine("Eleman sayisi:");
//girilen degeri al
int n = int.Parse(Console.ReadLine());
// dizi tanimla
int[] sayilar = new int[n];
// n adet donecek ve girilen sayilari diziye ekleyekctir
for (int i = 0; i < n; i++)
{
    Console.Write($"1.sayi {i + 1}:");
    sayilar[i] = int.Parse(Console.ReadLine());
}