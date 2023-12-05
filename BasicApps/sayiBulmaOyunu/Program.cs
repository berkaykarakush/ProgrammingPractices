//1-99 arasi sayi bulma oyunu

Random rnd = new Random(); //Random sinifindan rnd adinda nesne uretildi
int random = rnd.Next(1,100); //1-99 arasi

Console.WriteLine("Sayi bulma oyununa hosgeldiniz. "); //bilgi metni

int tahmin = 0, sayac = 1;

do
{
    Console.Write("1-99 arasi tahmininizi giriniz: "); //bilgi metni
    tahmin = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

    Console.WriteLine(tahmin == random ? $"Dogru bildiniz."  : //tahmin = random
                        (tahmin < random ? "Daha buyuk bir sayi giriniz." : //tahmin < random
                        (tahmin > random ? "Daha kucuk bir sayi giriniz." : ""))) ; //tahmin > random

    if (tahmin == random) //tahmin dogru ise 
        sayac = 0; //donguden cik

} while (sayac > 0); //0'sa cik