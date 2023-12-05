//okek = iki pozitif tamsayinin ortak katlarinin en kucugu 
//obeb = iki pozitif tamsayinin ortak bolenlerinin en buyugu

Console.Write("1. sayi degerini giriniz: ");//bilgi metni
int birinciSayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

Console.Write("2. sayi degerini giriniz: ");
int ikinciSayi = int.Parse(Console.ReadLine());

//okek
for (int i = 1; i < birinciSayi*ikinciSayi; i++)
{
    if ((i % birinciSayi == 0) && (i % ikinciSayi == 0)) //i mod birinciSayi = 0 & i mod ikinciSayi = 0
    {
        Console.WriteLine($"Okek({birinciSayi},{ikinciSayi}) = {i}");
        break;//cik
    }
}
int c = birinciSayi > ikinciSayi ? birinciSayi : ikinciSayi; // > 'se c = birinciSayi | < 'se c = ikincisayi

//obeb
for (int i = c; i > 0; i--)//azalan dongu
{
    if ((birinciSayi % i == 0) && (ikinciSayi % i == 0)) //birinciSayi mod i = 0 & ikinciSayi mod i = 0
    {
        Console.WriteLine($"Obeb({birinciSayi},{ikinciSayi}) = {i}");
        break;//cik
    }
}