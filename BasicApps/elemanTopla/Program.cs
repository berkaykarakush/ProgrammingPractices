//Tum elemanlari toplayan program
Console.Write("Kac adet eleman gireceksiniz ?: ");//bilgi metni
int elemanSayisi = int.Parse(Console.ReadLine());   //girilen degeri int'a cast et ve ata

//elemanlari tek tek al
int[] eleman = new int[elemanSayisi]; //girilen deger kadarlik dizi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{i + 1}. eleman: "); //bilgi metni
    eleman[i] = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve dizinin i'nci elemanina ata
}

int toplam = 0;//degisken tanimlama ve ilk deger atama
for (int i = 0; i < elemanSayisi; i++)//girilen eleman sayisi kadar don
{
    toplam += eleman[i]; //toplam = toplam + eleman[i]
}

Console.WriteLine($"Toplam: {toplam}");//sonuc yaz