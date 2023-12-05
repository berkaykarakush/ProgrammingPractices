class Program
{
    
    static void Main(string[] args)
    {
        //ebob/obeb = iki tamsayinin en buyuk ortak boleni

        Console.Write("1. sayi tamsayi degerini giriniz: ");//bilgi metni
        int birinciSayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

        Console.Write("2. sayi degerini giriniz: ");
        int ikinciSayi = int.Parse(Console.ReadLine());

        int k = birinciSayi > ikinciSayi ? ikinciSayi : birinciSayi; // >'se k=ikinciSayi | <'se k=birinciSayi

        byte i = 1;//dongu baslangic degiskeni
        while (i>0)//true
        {
            if ((!(birinciSayi % k == 0)) || (!(ikinciSayi % k == 0))) // birinciSayi mod k <> 0 VEYA ikinciSayi mod k <> 0
            { 
                k -= 1; //k = k -1;
            }
            else
            {
                Console.WriteLine($"Obeb({birinciSayi},{ikinciSayi}) = {k}");
                i = 0; //donguden cik
            }
        }

    }
}