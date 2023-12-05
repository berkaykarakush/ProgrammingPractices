 //cosinus bagintisi
Console.Write("Birinci kenar degerini giriniz: "); //bilgi metni
float birinciKenar = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Ikinci kenar degerini giriniz: ");
float ikinciKenar = float.Parse(Console.ReadLine());

Console.Write("Aradaki aci degerini giriniz: ");
float aciDegeri = float.Parse(Console.ReadLine());
//c=(a^2+b^2-2*a*b*cos(aci-pi/180)^(1/2)
Console.WriteLine("Ucuncu kenar degeri: " + Math.Sqrt((Math.Pow(birinciKenar, 2) + Math.Pow(ikinciKenar, 2)) - 2 * birinciKenar * ikinciKenar * Math.Cos(aciDegeri * Math.PI / 180)));