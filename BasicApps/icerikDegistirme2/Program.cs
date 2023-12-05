//iki sayinin aktarildigi degiskenlerin iceriklerini karsilikli olarak degistiren program 
Console.Write("1.Sayiyi giriniz: ");//bilgi metni
int birinciSayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("2.Sayiyi giriniz: ");
int ikinciSayi = int.Parse(Console.ReadLine());

birinciSayi += ikinciSayi; //birinciSayi = birinciSayi + ikinciSayi
ikinciSayi = birinciSayi - ikinciSayi; //toplamdan ikinciSayi'yi cikar ikinciSayi'ya ata boylece 2'nin degeri 1'e
birinciSayi = birinciSayi-ikinciSayi; //toplamdan ikinciSayiyi cikar birinciSayi'ya ata 1'in degeri 2'ye atanmis olur

Console.WriteLine($"1.Sayi degeri: {birinciSayi} \n2.Sayi degeri: {ikinciSayi}");