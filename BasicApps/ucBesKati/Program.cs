//7'den buyuk sayilar 3 ve 5 in katlari olarak yazilabilirler.Girilen tamsayi icin 3 ve 5'in katlarini bulan prgram
Console.Write("Sayi degerini giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

for (int a = 0; a < sayi/3; a++)//3'un kati
{
    for (int b = 0; b < sayi/5; b++)//5'in kati
    {
        if(3*a + 5*b == sayi)
        {
            Console.WriteLine($"3'un kati: {a} | 5'in kati: {b}");
        }
    }
}