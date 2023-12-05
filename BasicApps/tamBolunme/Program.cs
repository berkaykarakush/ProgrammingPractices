//a sayisinin b sayisina tam bolunme kontrolu

Console.Write("Birinci sayi degerini giriniz: "); //bilgi metni
int birinciSayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("Ikinci sayi degerini giriniz: ");
int ikinciSayi = int.Parse(Console.ReadLine());

//birinciSayi % ikinciSayi == 0 ise ilk durum, degilse ikinci durum tetiklenecek
Console.WriteLine(birinciSayi % ikinciSayi == 0 ? $"{birinciSayi} sayisi {ikinciSayi} sayisina tam bolunuyor" : $"{birinciSayi} sayisi {ikinciSayi} sayisina tam bolunmuyor");