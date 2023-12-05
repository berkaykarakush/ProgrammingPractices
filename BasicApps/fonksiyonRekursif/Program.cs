class Program
{
    public static int faktoriyel(int k) 
    {
        if (k <= 1) return 1; //0!=1 | 1!=1
        else return k * faktoriyel(k - 1); //3.2.1! seklinde 
    }
    static void Main(string[] args)
    {
        //faktoriyel islemini rekursif olarak hesaplama 

        Console.Write("Sayi: "); //bilgi metni
        int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

        Console.WriteLine($"{sayi}! = {(faktoriyel(sayi))}"); //fonksiyonu cagir ve yaz
    }


}