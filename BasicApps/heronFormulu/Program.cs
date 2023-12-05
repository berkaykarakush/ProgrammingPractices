//heron formulu ile ucgen alani hesaplama 
Console.Write("Birinci kenar degerini giriniz: ");//bilgi metni
float birinciKenar = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("Ikinci kenar degerini giriniz: ");
float ikinciKenar = float.Parse(Console.ReadLine());

Console.Write("Ucuncu kenar degerini giriniz: ");
float ucuncuKenar = float.Parse(Console.ReadLine());

float u = (birinciKenar+ikinciKenar+ucuncuKenar)/2;//u=(a+b+c)/2

Console.WriteLine("Alan: " + Math.Sqrt(u * (u - birinciKenar) * (u - ikinciKenar) * (u - ucuncuKenar)));// (u*(u-a)*(u-b)*(u-c))^(1/2)