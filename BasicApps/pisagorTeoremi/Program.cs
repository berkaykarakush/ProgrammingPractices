//pisagor teoremi 
Console.Write("Birinci dik kenar degerini giriniz: "); //bilgi metni
int birinciKenar = int.Parse(Console.ReadLine()); //ilk degeri int'e cast et ve ata

Console.Write("Ikinci dik kenar degerini giriniz: ");
int ikinciKenar = int.Parse(Console.ReadLine());

Console.WriteLine("Hipotenus: " + (Math.Sqrt(Math.Pow(birinciKenar, 2) + Math.Pow(ikinciKenar, 2)))); //c=(a^2+b^2)^(1/2)