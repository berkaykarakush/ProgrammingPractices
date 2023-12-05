//girilen n adet tam sayi icerisinden en buyuk cift sayiyi bulan program

Console.Write("Kac adet sayi gireceksiniz: "); //bilgi metni
int n = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

int enBuyukSayi = -1; //degisken tanmimlama ve ilk deger atama 

for (int i = 0; i < n; i++) //istenen adet kadar sayi girisini sagla
{
    Console.Write("Sayi degerini giriniz: ");
    int sayi = int.Parse(Console.ReadLine());

    if ((sayi % 2 == 0) && (sayi > enBuyukSayi)) //sayi cift ve son  enBuyukSayi degerinden buyukse tetiklenir
        enBuyukSayi = sayi; //enBuyukSayiyi guncelle
}

Console.WriteLine(enBuyukSayi == -1 ? "Cift tam sayi yok." : //cift sayi girilmemisse 
                                        $"En buyuk cift tamsayi degeri: {enBuyukSayi}"); //girilen en buyuk cift sayiyi yaz