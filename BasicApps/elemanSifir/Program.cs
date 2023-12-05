//tum elemanlari sifir olan bir dizi olusturma
Console.Write("Dizinin eleman sayisini giriniz: ");//bilgi metni
int elemanSayisi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

int[] dizi = new int[elemanSayisi]; //girilen deger kadarlik dizi tanimla 
for (int i = 0; i < elemanSayisi; i++)
{
    dizi[i] = 0; //tum elemanlara sifir ata
    Console.WriteLine($"Dizinin {i+1}. elemani: {dizi[i]}");
}