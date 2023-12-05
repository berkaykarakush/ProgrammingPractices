//Herhangi bir pozitif tamsayinin ussu sayinin kendisiyle belirtilen us kadar carpimidir 

Console.Write("Sayiyi giriniz: ");//bilgi metni
int sayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("Us degerini giriniz: ");
int us = int.Parse(Console.ReadLine());

int carpim = 1; //degisken tanimlama ve ilk deger atama 
for (int i = 1; i <= us; i++) //carpma oldugu icin 1'den basla us degeri dahil
{
    carpim *= sayi; //caprim = carpim * sayi;
}

Console.WriteLine($"{sayi}^{us} = {carpim}");