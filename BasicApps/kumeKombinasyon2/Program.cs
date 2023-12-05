class Program
{
    //kombinasyon hesaplama 

    static float faktoriyel(int x)//metot
    {
        float z = 1;
        for (int y = 1; y <= x; y++)//carpma oldugu icin 1'den 5'e kadar demem icin <= kullanmam gerek
        {
            z *= y; // z= z*y;
        }
        return z; //z degeri dondurur
    }

    static void Main(string[] args)
    {

        Console.Write("C(n,r) \nn degerini giriniz: "); //bilgi metni 
        int n = int.Parse(Console.ReadLine()); //girilen degeri int'e cast et ve ata

        Console.Write("r degerini giriniz: ");
        int r = int.Parse(Console.ReadLine());

        //5'in 3'lusu derken 5!/(3!(5!-3!)) oldugundan 5.4.3.2.1/(3.2.1)(2.1) olacaktir 
        //f1=n | f2=r | f3=n-r
        float f1 = faktoriyel(n);
        float f2 = faktoriyel(r);
        float f3 = faktoriyel(n-r);

        float k = f1 / (f2 * f3); //k = f1 / f2.f3
        Console.WriteLine($"sonuc: {k}"); //sonuc 5'in 3'lusu icin 10 olur
    }
}