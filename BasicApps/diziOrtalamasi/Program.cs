//girilen dizinin aritmetik, harmonik, geometrik ve kontraharmonik ortalamasini hesaplayan program

#region  degisken tanimlama ve ilk deger atama
int elemanSayisi = 0;
float toplam = 0f;
float carpim = 1f;
float harmonikToplam = 0f;
float toplamUs = 0f;
float aritmetikOrt = 0f;
float geometikOrt = 0f;
float harmonikOrt = 0f;
float kontraharmonikOrt = 0f;
#endregion

Console.Write("Dizinin eleman sayisini giriniz: ");//eleman sayisini iste
elemanSayisi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

float[] dizi = new float[elemanSayisi];//elemanSayisi kadarlik dizi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{(i + 1)}'nci eleman: ");//eleman degerini iste
    dizi[i] = int.Parse(Console.ReadLine());//girilen degeri dizinin i'nci indisine ata
    toplam += dizi[i];//elemanlar toplami
    carpim *= dizi[i];//elemanlar carpimi
    harmonikToplam += (1 / dizi[i]);//elemanlarin harmonik toplami
    toplamUs += dizi[i] * dizi[i];//elemanlarin uslerini topla, bilincli tur donusumu uygulanmistir
}

aritmetikOrt = toplam / elemanSayisi; //aritmetik ortalama = elemanlarin toplami / eleman sayisi 
geometikOrt = (float)(Math.Pow(carpim, (1.0f / elemanSayisi))); //geometrik ortalama = carpim ^ (1/eleman sayisi)
harmonikOrt = elemanSayisi / harmonikToplam; //harmonik ortalama = eleman sayisi / harmonik toplam
kontraharmonikOrt = toplamUs / toplam; //kontraharmonik ortalama = toplamUs / toplam

Console.WriteLine($"Artimetik ortalama: {aritmetikOrt,0:F3} \nGeometrik Ortalama: {geometikOrt,0:F3} \nHarmonik Ortalama: {harmonikOrt,0:F3} \nKontraHarmonik Ortalama: {kontraharmonikOrt,0:F3}");//sonuc yaz
        