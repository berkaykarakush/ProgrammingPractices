//n elemanli diziyi k sayisi ile carpip yeni diziye yazdiran program
Console.Write("Dizinin eleman sayisini giriniz: ");//bilgi metni
int elemanSayisi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

Console.Write("Diziyi carpmak istediginiz degeri giriniz: ");
int katsayi = int.Parse(Console.ReadLine());

//1'nci dizi
int[] birinciDizi = new int[elemanSayisi];//girilen eleman sayisi kadarlik dizi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{i+1}'nci eleman: ");//eleman al
    birinciDizi[i] = int.Parse(Console.ReadLine());//girilen degeri dizinin i'nci indeksine ata
}

//2'nci dizi
int[] ikinciDizi = new int[elemanSayisi];//girilen elemanSayisi kadarlik yeni dizi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    ikinciDizi[i] = birinciDizi[i] * katsayi; //her elemani katsayi ile carp ve yeni diziye ata
    Console.WriteLine($"A[{birinciDizi[i]}] * {katsayi} = {ikinciDizi[i]}");//sonuz yaz
}