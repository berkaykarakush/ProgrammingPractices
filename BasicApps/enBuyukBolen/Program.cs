//girilen pozitif tamsayinin en buyuk bolenini hesaplama

Console.Write("Say degerini giriniz: ");//bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

int bolen = sayi == 1 ? bolen = 1 : bolen = sayi / 2; //1'se bolen=1 | 1 degilse bolen=sayi/2
int sayac = 1;
while (sayac > 0)
{
    if ((bolen > 1) && (!(sayi % bolen == 0)))
    {
        bolen -= 1; //bolen = bolen - 1
    }
    else
    {
        Console.WriteLine($"En buyuk bolen: {bolen}");
        sayac = 0;//donguden cik
    }
}