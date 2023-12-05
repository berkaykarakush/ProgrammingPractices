 //iki bilinmeyenli denklem 

Console.Write("ax+by=c \ndx+ey=f \n"); //bilgi metni

Console.Write("a degerini giriniz: "); //bilgi metni
float a = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("b degerini giriniz: ");
float b = float.Parse(Console.ReadLine());

Console.Write("c degerini giriniz: ");
float c = float.Parse(Console.ReadLine());

Console.Write("d degerini giriniz: ");
float d = float.Parse(Console.ReadLine());

Console.Write("e degerini giriniz: ");
float e = float.Parse(Console.ReadLine());

Console.Write("f degerini giriniz: ");
float f = float.Parse(Console.ReadLine());


float x = (c-b*f/e)/(a-b*d/e); // x = c-b*f/3  / a-b*d/e
float y = (c-a*x)/b; //y = c-a*x / b

Console.WriteLine($"x: {x} \ny: {y}");