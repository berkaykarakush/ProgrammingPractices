//ohm kanunu
Console.Write("Iletkenin direncini giriniz (R): "); //bilgi metni
float R = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Iletkenin icinden akan akim degerini giriniz (I):");
float I = float.Parse(Console.ReadLine());

Console.WriteLine("Gerilim: " + (R * I));//v=r*i