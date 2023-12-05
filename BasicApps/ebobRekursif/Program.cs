class Program
    {
        public static int ebob (int x, int y)
        {
            if (y == 0) { return x; }
            else { return ebob (y, x % y);  }
        }
        static void Main(string[] args)
        {
            //ebob/obeb = iki tamsayinin en buyuk ortak boleni

            Console.Write("1. sayi tamsayi degerini giriniz: ");//bilgi metni
            int birinciSayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

            Console.Write("2. sayi degerini giriniz: ");
            int ikinciSayi = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cevap = {ebob(birinciSayi,ikinciSayi)}");
        }
    }