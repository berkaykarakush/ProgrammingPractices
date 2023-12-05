//derece cinsinden girilen aciyi radyan ve gradyana donusturme

const float pi = 3.14f; //pi sayisi sabit olarak olusturuldu

Console.Write("Aci degerini giriniz (derece): ");
float derece = float.Parse(Console.ReadLine()); //girilen degeri int'e cast et ve ata

Console.WriteLine("Radyan degeri: " + derece*pi/180); //radyan=derece*pi/180
Console.WriteLine("Gradyan degeri: " +derece*200/180); //gradyan=derece*200/180