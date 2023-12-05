//secime gore mevsim aylarini gosteren program
            
Console.Write("Mevsimlerin aylarini goruntulemek icin mevsim seciniz. \n1-Ilkbahar \n2-Yaz \n3-Sonbahar \n-4Kis \nSeciminiz: ");//bilgi metni
byte secim = byte.Parse(Console.ReadLine());//girilen degeri byte'a cast et ve ata

Console.WriteLine(secim == 1 ? "Mart, Nisan, Mayis" : //ilkbahar
                    (secim == 2 ? "Haziran, Temmuz, Agustos": //yaz
                    (secim == 3 ? "Eylul, Ekim, Kasim" : //sonbahar
                    (secim == 4 ? "Aralik, Ocak, Subat"://kis
                    "Yanlis secim yaptiniz.Lutfen 1-4 arasinda bir sayi giriniz."))));//default