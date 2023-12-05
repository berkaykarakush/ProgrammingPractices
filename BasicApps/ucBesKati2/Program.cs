//7'den buyuk sayilar 3 ve 5 in katlari olarak yazilabilirler.Girilen tamsayi icin 3 ve 5'in katlarini bulan prgram
Console.Write("Sayi degerini giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

for (int a = 0; a < sayi; a+=3)//3'un kati
{
    for (int b = 0; b < sayi; b+=5)//5'in kati
    {
        if (a+b == sayi)
        {
            Console.WriteLine($"3'un kati: {a/3} | 5'in kati: {b/5}");
        }
    }
}