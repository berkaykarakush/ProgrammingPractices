//ikinci dereceden denklem hesaplama
Console.Write("ax^2 + bx + c = 0 \nD = b^2 - 4ac \n");//bilgi metni

Console.Write("a degerini giriniz: "); //bilgi metni
float a = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("b degerini giriniz: ");
float b= float.Parse(Console.ReadLine());

Console.Write("c degerini giriniz: ");
float c = float.Parse(Console.ReadLine());

//bilincli tur donusumu
float diskriminat = (float)Math.Pow(b,2) - 4 * a * c; //d= b^2 - 4ac

float x1, x2; //a(x1)^2 + b(x2) + c = 0
if (diskriminat > 0) //diskriminatn 0'dan buyukse 
{
    //bilincli tur donusumu
    x1 = (float)(-b - Math.Sqrt(diskriminat)) / (2 * a); // x1 = (-b-(diskriminat)^(1/2))/(2*a)
    x2 = (float)(-b + Math.Sqrt(diskriminat)) / (2 * a); //x2 = (-b+(diskriminat)^(1/2))/(2*a)

    Console.WriteLine($"x1: {x1} \nx2: {x2}");
}
else if (diskriminat == 0) //diskriminant = 0 
{
    x1 = -b / (2 * a); //x1 = -b/(2*a)
    Console.WriteLine($"x1: {x1}");
}
else //diskriminant < 0 tetiklenir
{
    Console.WriteLine("Sanal kokler");
}