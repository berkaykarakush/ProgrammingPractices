//a tamsayisi icin 1/a bolumun ilk b basamagini gosteren program

Console.Write("Bir tamsayi degeri giriniz: ");//bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

Console.Write("Basamak degerini giriniz: "); 
int basamak = int.Parse(Console.ReadLine());

int i = 0, r = 1; //degisken tanimlama ve ilk deger atama 

Console.Write($"1 / {sayi} = 0."); //on metin

while (!(i == basamak)) //i <> basamak
{
    Console.Write($"{(10*r/sayi)}"); 
    r = 10 * r % sayi; //r = 10 * r mod sayi
    i++; //arttir
}