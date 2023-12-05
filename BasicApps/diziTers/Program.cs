//a dizisinin elemanlarini b dizisine tersten yazdiran program
Console.Write("Dizinin eleman sayisini giriniz: ");//bilgi metni
int elemanSayisi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

#region 1'nci dizi
int[] biriniciDizi = new int[elemanSayisi];//girilen eleman sayisi kadarlik dizi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{(i + 1)}'nci eleman: ");//eleman degerini al
    biriniciDizi[i] = int.Parse(Console.ReadLine());//girilen degeri dizinin i'nci indisine ata
}
#endregion

Console.WriteLine("********************");

#region 2'nci dizi
int[] ikinciDizi = new int[elemanSayisi];//girilen eleman sayisi kadarlik dizi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    ikinciDizi[i] = biriniciDizi[elemanSayisi -1 - i];// j = n -1 -i iliskisi kullanilmistir, yani i 1'den N'1 kadar artarken j degiskeni de
                                                        // ayni oranda azaliyorsa aralarinda kullailan ilsikidir
    Console.WriteLine($"{(i + 1)}'nci eleman: {ikinciDizi[i]}");

}
#endregion