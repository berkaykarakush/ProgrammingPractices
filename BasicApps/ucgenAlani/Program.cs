//bir kenar uzunlugu ve yukseklik degeri girilen ucgenin alani

Console.Write("Kenar degerini giriniz: ");//bilgi metni
int kenar = int.Parse(Console.ReadLine()); //girilen degeri int'e cast et ve ata

Console.Write("Yukseklik degerini giriniz: "); 
int yukseklik = int.Parse(Console.ReadLine());

Console.WriteLine("Ucgenin alani: " + kenar*yukseklik/2); //alan=kenar*yukseklik/2