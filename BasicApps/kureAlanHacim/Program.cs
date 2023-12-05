//kure alan ve hacim hesaplama 
Console.Write("Kurenin yaricapi degerini giriniz: "); //bilgi metni 
float yaricap = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.WriteLine("Kurenin alani: " + (4 * Math.PI * Math.Pow(yaricap, 2)));//alan=4*pi*r^2
Console.WriteLine("Kurenin hacmi: " + (4 * Math.PI * Math.Pow(yaricap, 3) / 3));//hacim=(4*pi*r^3)/3