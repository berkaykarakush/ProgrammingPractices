//girilen b sayisi icin a^3 - a^2 = b icin 0 < a < 100 bulan program 
Console.Write("a^3 - a^2 = b icin \nb tamsayisini giriniz: "); //bilgi metni
int b = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata
byte kontrol = 0; //degisken tanimalama ve ilk deger atama 

for (int a = 1; a < 99; a++)
{
    if ((Math.Pow(a, 3) - Math.Pow(a, 2)) == b) //a^3 - a^2 = b
    {
        Console.Write($"Bu sarta uyan sayi: {a}"); //a yaz
        kontrol = 1; //kontrol degerini degistir ki sayi yoktur kontrolu devre disi kalsin
    }
}

Console.WriteLine(kontrol == 1 ? "" : //true 
                                 "0-100 arasinda boyle bir sayi yoktur."); //false