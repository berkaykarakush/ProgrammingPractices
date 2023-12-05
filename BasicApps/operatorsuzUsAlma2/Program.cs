//Herhangi bir pozitif tamsayinin ussu sayinin kendisiyle belirtilen us kadar carpimidir 

Console.Write("Sayiyi giriniz: ");//bilgi metni
int sayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("Us degerini giriniz: ");
int us = int.Parse(Console.ReadLine());

//degisken tanimlama ve ilk deger atama
int sonuc = 1;
int carpim = sayi;  

while(!(us == 0)) 
{
    if (us % 2 == 0) 
    {
        us /= 2; ///us= us / 2;
        carpim *= carpim; //carpim = carpim * carpim;
    }
    else
    {
        us -= 1; //us = us - 1;
        sonuc *= carpim; //sonuc = sonuc * carpim;
    }
}
Console.WriteLine($"Sonuc  = {sonuc}");