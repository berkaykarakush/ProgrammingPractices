//pozitif bir sayinin, tamsayi olup olmadigini kontrol eden program

Console.Write("Pozitif bir sayi giriniz: ");//bilgi metni
float sayi = float.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

//girilen deger == yuvarlanmis hali 
Console.WriteLine(sayi == Math.Round(sayi) ? $"{sayi} sayisi bir tamsayidir." : //==
                                                $"{sayi} sayisi bir tamsayi degildir."); //!=