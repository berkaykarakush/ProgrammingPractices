//pozitif bir tamsayinin tam bolenleri - hizlandirilmis versiyon

Console.Write("Bir tam sayi degeri giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.WriteLine("1");//1 yaz cunu her sayi 1'e bolunur
for (int i = 2; i <= sayi/2; i++) //girilen degerin yarisi kadar don
{
    if (sayi % i == 0) //true
        Console.WriteLine(i);//yaz
}