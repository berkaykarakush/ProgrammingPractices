//girilen bir noktanin ax+by+c=0 dogrusu uzerinde olup olmadigini, eger degilse noktanin dogruya olan uzakligini veren program
Console.WriteLine("ax + by + x = 0");//bilgi metni
Console.Write("a degerini giriniz: "); //bilgi metni
float a = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("b degerini giriniz: ");
float b = float.Parse(Console.ReadLine());

Console.Write("c degerini giriniz: ");
float c = float.Parse(Console.ReadLine());

Console.Write("x degerini giriniz: ");
float x = float.Parse(Console.ReadLine());

Console.Write("y degerini giriniz: ");
float y = float.Parse(Console.ReadLine());

float uzaklik = 0; //degisken tanimlama ve ilk deger atama

// ==0 ise "": tetiklenir, esit degilse :"" tetiklenir
Console.WriteLine(a*x+b*y+x == 0 ? "Girilen nokta dogru uzerindedir." : //a*x + b*y + c = 0
    $"Girilen nokta dogru uzerinde degildir.Noktanin dogruya olan uzakligi {Math.Abs(a*x+b*y+c)/Math.Sqrt(Math.Pow(a,2)+ Math.Pow(b, 2))} birimdir."); 
    //uzaklik =|a*x+b*y+x|/(a^2+b^2)^(1/2)