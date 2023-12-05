//n elemanli a ve b dizilerinin skaler carpimini hesaplayan program
Console.Write("Dizilerin eleman sayisini giriniz: ");//bilgi metni
int elemanSayisi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

#region 1'nci dizi
int[] birinciDizi = new int[elemanSayisi];//n elemanli dizi olustur
for (int i = 0; i < elemanSayisi; i++) 
{
    Console.Write($"{(i + 1)}'nci eleman: ");//eleman degerlerini iste
    birinciDizi[i] = int.Parse(Console.ReadLine()); //girilen deger int'a cast et ve i'nci indise ata    
}
#endregion

Console.WriteLine("******************");

#region 2'nci dizi
int[] ikinciDizi = new int[elemanSayisi]; //n elemanli dizi olustur
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{(i + 1)}'nci eleman: ");//eleman degerlerini iste
    ikinciDizi[i] = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve i'nci indise ata
}
#endregion

#region SkalerCarpim

int skalerCarpim = 0; //degisken tanimlama ve ilk deger atama
for (int i = 0; i < elemanSayisi; i++)
{
    skalerCarpim += birinciDizi[i] * ikinciDizi[i]; //skalerCarpim = skalerCarpim + A[i} * B[i]
}
Console.WriteLine($"Skaler Carpim = {skalerCarpim}"); //sonuc yaz
#endregion