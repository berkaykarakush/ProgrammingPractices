//kombinasyon hesaplama 

Console.Write("C(n,r) \nn degerini giriniz: "); //bilgi metni 
int n = int.Parse(Console.ReadLine()); //girilen degeri int'e cast et ve ata

Console.Write("r degerini giriniz: ");
int r = int.Parse(Console.ReadLine());

float f1=1, f2=1, f3=1,k;//f1=n | f2=r | f3=n-r

//5'in 3'lusu derken 5!/(3!(5!-3!)) oldugundan 5.4.3.2.1/(3.2.1)(2.1) olacaktir 
for(int i =1; i<=n; i++) //carpma oldugu icin 1'den 5'e kadar demem icin <= kullanmam gerek
{
    f1 *= i; // f1 = f1 * i
    if (i <= r)
        f2 *= i;// f2 = f2 * i
    if (i <= n - r) 
        f3 *= i; // f3 = f3 * i

}

    k = f1 / (f2 * f3); //k = f1 / f2.f3

Console.WriteLine($"sonuc: {k}"); //sonuc 10 olur