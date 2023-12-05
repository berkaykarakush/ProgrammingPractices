//birinci derece denklem hesaplama
float a, b, c; //degisken tanimlama
Console.Write("ax+b=c \n"); //bilgi metni
//a'nin sifir olma durumunu kontrol et 
do
{
    Console.Write("a degerini giriniz:"); //bilgi metni
    a = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata
    
    if (a == 0)
        Console.WriteLine("Sifirdan farkli bir deger giriniz.");
    
} while (a == 0);
//a sifir degilse isleme basla
if (!(a == 0)) // a != 0
{
    Console.Write("b degerini giriniz: ");
    b = float.Parse(Console.ReadLine());

    Console.Write("c degerini giriniz: ");
    c = float.Parse(Console.ReadLine());

    Console.WriteLine($"x = {(c - b) / a}"); //x = c-b /a 
}