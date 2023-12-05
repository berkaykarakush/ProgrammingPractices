Console.Write("Birinci kosegen degerini giriniz: "); //bilgi metni
float birinciKosegen = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Ikinci kosegen degerini giriniz: ");
float ikinciKosegen = float.Parse(Console.ReadLine());

Console.Write("Aradaki aci degerini giriniz: ");
float aciDegeri = float.Parse(Console.ReadLine());
//alan=e*f*sin(aci*pi/180)/2
Console.WriteLine("Alan: " + ((birinciKosegen * ikinciKosegen * Math.Sin(aciDegeri * Math.PI / 180)) / 2));