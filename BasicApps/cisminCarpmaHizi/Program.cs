//yerden yuksekligi ve ilk hizi girilen cismin havada kalmas suresi, yatayda alacagi yol ve yere carpma hizi hesaplama 
Console.Write("Cismin yerden yuksekligini giriniz: "); //bilgi metni
double h = double.Parse(Console.ReadLine()); //girilen degeri double'a cast et ve ata

Console.Write("Cismin hizini giriniz: ");
double vo = double.Parse(Console.ReadLine());

double t = Math.Sqrt(2 * h / 9.8);//t=(2*h/9.8)^(1/2)
double x = vo*t;//x=vo*t
double vy = 9.8 * t; //vy = 9.8*t
double v = Math.Sqrt(Math.Pow(vo, 2) + Math.Pow(vy, 2));//v=(vo^2+vy^2)^(1/2)


Console.WriteLine($"Cismin havada kalma suresi: {t}"); 
Console.WriteLine($"Cismin yatayda alacgi yol: {x}");
Console.WriteLine($"Cismin yere carpma hizi: {v}");