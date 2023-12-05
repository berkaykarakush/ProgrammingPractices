//girilen sayinin 10 tabanindaki gosterimi

Console.Write("Pozitif bir tam sayi degeri giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

int i = sayi; //islemde kullanicak olan sayi degeri
int sayac = 0; //gosterimde artan deger olarak kullanildi

Console.Write("On Tabaninda gosterim = ");

//sayiyi rakamlarina parcalama islemi
while (!(i == 0)) //i<>0
{
    Console.Write($" {(i % 10)}.10^{sayac} + "); //son basamagi yaz
    i = (int)(i / 10); //i = i /10 , bolme islemi ile kalan basamagi al
    sayac += 1; //bir artir
}