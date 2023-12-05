//1. yontemle ideal kilo hesaplayan program
Console.Write("Boyunuzu giriniz(m): "); //bilgi metni
float boy = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata 

Console.Write("Kilonuzu giriniz(kg): ");
float kilo = float.Parse(Console.ReadLine());

Console.Write("Cinsiyetinz kadin mi?(true/false):");
bool cinsiyet = bool.Parse(Console.ReadLine());

////bilincli tur donusumu uygulanmistir
float bedenYuzeyAlani = 0.20247f * (float)(Math.Pow(boy, 0.725f)) * (float)(Math.Pow(kilo, 0.425f)); //bya = 0.20247 * boy^0.725 * kilo^0.425 
float bedenKutleIndeksi = kilo / (float)(Math.Pow(boy, 2)); //bki = kilo / boy*boy

//ideal kilo 
float idealKilo = 0;
if(cinsiyet) //true/kadin ise 
{
    //1 m =  39.3700787 inch
    idealKilo = 45.5f + 2.3f * ((boy * 39.3700787f) - 60f); //45.5 + 2.3*[boy(inch) - 60]    
}
else//false/erkek icin
{
    idealKilo = 50f + 2.3f * ((boy * 39.3700787f) - 60f); //50 + 2.3*[boy(inch) - 60]    

}

Console.WriteLine($"Ideal Kilo: {idealKilo}");