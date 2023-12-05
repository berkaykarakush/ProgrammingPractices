//2. yontemle ideal kilo hesaplayan program
Console.Write("Boyunuzu giriniz(m): "); //bilgi metni
float boy = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata 

Console.Write("Kilonuzu giriniz(kg): ");
float kilo = float.Parse(Console.ReadLine());

Console.Write("Yasinizi giriniz: ");
int yas = int.Parse(Console.ReadLine());

Console.Write("Cinsiyetinz kadin mi?(true/false):");
bool cinsiyet = bool.Parse(Console.ReadLine());

////bilincli tur donusumu uygulanmistir
float bedenYuzeyAlani = 0.20247f * (float)(Math.Pow(boy, 0.725f)) * (float)(Math.Pow(kilo, 0.425f)); //bya = 0.20247 * boy^0.725 * kilo^0.425 
float bedenKutleIndeksi = kilo / (float)(Math.Pow(boy, 2)); //bki = kilo / boy*boy

//ideal kilo 
float idealKilo = 0f;
if (cinsiyet) //true/kadin ise 
{
    idealKilo = ((boy * 100f) - 100f + (yas / 10f)) * 0.8f; 
}
else//false/erkek icin
{
    idealKilo = ((boy * 100f) - 100f + (yas / 10f)) * 0.9f;
}

Console.WriteLine($"Ideal Kilo: {idealKilo}");