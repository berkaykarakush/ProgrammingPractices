//potansiyel ve kinetik enerji hesaplama 
Console.Write("Maddenin kutlesini giriniz(m): ");//bilgi metni
float m = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Maddenin hizini (v) giriniz: ");
float v = float.Parse(Console.ReadLine());

Console.Write("Maddenin yerden yuksekligini (h) giriniz: ");
float h = float.Parse(Console.ReadLine());

Console.WriteLine("Potansiyel Enerji: " + (m * 9.8 * h));//ep=m*9.8*h
Console.WriteLine("Kinetik Enerji: " + (m * Math.Pow(v, 2) / 2)); //ek=m*v^2/2