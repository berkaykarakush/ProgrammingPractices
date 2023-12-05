//Girilen tamsayinin tek mi cift mi oldugu hesaplama 
Console.Write("Bir tamsayi giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.WriteLine(sayi %2 == 0 ? "Girilen sayi cift sayidir":"Girilen sayi tek sayidir"); //sayi mod 2 esitse 0 cifft, sayi mod 2 esit degilse 0 tek