//baska bir dizi kullanmadan dizinin elemanlarini tersten yazdirma 
Console.Write("Dizinin eleman sayisini giriniz: ");//bilgi metni
int elemanSayisi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

int[] dizi = new int[elemanSayisi]; //girilen eleman sayisi kadarlik dizi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{(i + 1)}'nci eleman: ");//eleman degerlerini al
    dizi[i] =int.Parse(Console.ReadLine());//girilen degeri cast et ve i'nci indise ata
}

Console.WriteLine("*****************");

Array.Reverse(dizi); //Array sinifina ait Reverse metotu kullanilarak dizi tersten siraldirildi

for (int i = 0; i < elemanSayisi; i++)
{
    Console.WriteLine($"{(i + 1)}'nci eleman: {dizi[i]}"); 
}