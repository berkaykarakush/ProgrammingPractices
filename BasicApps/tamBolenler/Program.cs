//pozitif bir tamsayinin tam bolenleri

Console.Write("Bir tam sayi degeri giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

for(int i=1; i<=sayi; i++) //girilen deger kadar don, 1'den baslama sebebi 0'a bolem hatasi almamak
{
    if(sayi%i == 0) //true
        Console.WriteLine(i);//yaz
}