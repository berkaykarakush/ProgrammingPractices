class Program
{
    static void Main(string[] args)
    {
        //ebob/obeb = iki tamsayinin en buyuk ortak boleni

        Console.Write("1. sayi tamsayi degerini giriniz: ");//bilgi metni
        int birinciSayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

        Console.Write("2. sayi degerini giriniz: ");
        int ikinciSayi = int.Parse(Console.ReadLine());

        int k = 0;
        while (true)
        {
            if ((!(birinciSayi == 0)) && (!(ikinciSayi == 0))) //birinciSayi <> 0 VE ikinciSayi <> 0
            {
                if (birinciSayi >= ikinciSayi) 
                    birinciSayi -= ikinciSayi; //birinciSayi = birinciSayi - ikinciSayi
                else
                    ikinciSayi -= birinciSayi; //ikinciSayi = ikinciSayi - birinciSayi
            }
            else if (birinciSayi == 0) // 0'sa
            {
                k = ikinciSayi;
                break; //cik
            }
            else
            {
                k = birinciSayi;
                break;//cik
            }
        }

        Console.Write($"Ebob = {k}");//sonuc yaz

    }
}