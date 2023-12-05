//bir radyoaktif elementin belirtilen sure sonunda kac yarilanma geciregini ve kutlesinin ne kadar kalacagini hesaplama 
Console.Write("Baslangic kutlesini giriniz (mo): "); //bilgi metni
float mo = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("Yarilanma suresini giriniz (dt):");
float dt = float.Parse(Console.ReadLine());

Console.Write("Sureyi giriniz (t): ");
float t = float.Parse(Console.ReadLine());

float n = t / dt;
float m = mo / (float)Math.Pow(2, n); //math.pow'dan donen double degeri float'a bilincli tur donusumu yap 

Console.WriteLine($"Yarilanma Sayisi: {n} \nKalan Kutle: {m} "); //kalan kutle yeni satirdan yazar " \n : new line "