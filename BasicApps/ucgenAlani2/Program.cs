//iki kenari ve dereece cinsinden aradaki acisi verilen ucgen alani
const float pi = 3.14f; //pi sayisini sabit olarak olustur 

Console.Write("Birinci kenar degerini giriniz: ");//bilgi metni
float birinciKenar = float.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("Ikinci kenar degerini giriniz: ");
float ikinciKenar = float.Parse(Console.ReadLine());

Console.Write("Aradaki aci degerini giriniz (derece): ");
float aciDegeri = float.Parse(Console.ReadLine());  

double  alan = birinciKenar*ikinciKenar*Math.Sin(aciDegeri*pi/180)/2; //alan=birincikenar*ikincikenar*sin(aci*pi/180)/2

Console.WriteLine($"Ucgenin alani: {alan}");//sonuc 