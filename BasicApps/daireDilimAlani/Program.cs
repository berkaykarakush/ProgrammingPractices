//daire diliminin alan hesabi
Console.Write("Yaricap degerini giriniz: "); //bilgi metni
float yaricap = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("Aci degerini giriniz (derece): ");
float aciDegeri = float.Parse(Console.ReadLine());

Console.WriteLine("Alan: " + ((aciDegeri * Math.PI * Math.Pow(yaricap, 2)) / 360));//alan = (aci*pi*r^2)/360