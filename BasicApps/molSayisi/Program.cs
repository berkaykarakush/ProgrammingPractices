//maddenin mol sayisini hesaplama 
Console.Write("Maddenin kutlesini giriniz (m): "); //bilgi metni
float kutle = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Maddenin molekul agirligini giriniz (ma): ");
float molekulAgirligi = float.Parse(Console.ReadLine());

Console.WriteLine("mol: " + kutle/molekulAgirligi); //mol=m/ma