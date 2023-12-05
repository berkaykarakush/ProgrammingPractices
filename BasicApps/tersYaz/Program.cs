//girilen tamsayiyi tersten yazdiran program

Console.Write("Tersten yazdirilmak istenen sayiyi giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata 

int kalan = 0;//degisken tanimlama ve ilk deger atama 
while (!(sayi == 0)) //kalan <> 0 
{
    kalan = sayi % 10; // sayinin en sagindaki rakami aldik
    Console.Write($"{kalan}"); 
    sayi = sayi / 10; //sayi degerini 10'a bolerek sonsuz donguden kurtulduk
}