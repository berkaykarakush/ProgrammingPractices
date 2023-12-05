//iki sayinin aktarildigi degiskenlerin iceriklerini karsilikli olarak degistiren program 

Console.Write("1.Sayiyi giriniz: ");//bilgi metni
int birinciSayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("2.Sayiyi giriniz: ");
int ikinciSayi = int.Parse(Console.ReadLine());

int tut = 0; //degisken tanimlama ve ilk deger atama 
tut = birinciSayi; //birinciSayi farkli bir degiskende tutuluyor
birinciSayi = ikinciSayi; //ikinciSayi birinciSayi'ya aktarildi
ikinciSayi = tut; //birinciSayi ikinciSayi'ya aktarildi

Console.WriteLine($"1.Sayi degeri: {birinciSayi} \n2.Sayi degeri: {ikinciSayi}");