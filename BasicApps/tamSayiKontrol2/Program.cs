  //pozitif bir sayinin, tamsayi olup olmadigini kontrol eden program

Console.Write("Pozitif bir sayi giriniz: ");//bilgi metni
float sayi = float.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

//herhangi bir sayinin 1'e gore modu 0 ise tamsayidir
Console.WriteLine(sayi % 1 == 0 ? $"{sayi} sayisi bir tamsayidir." : //==
                                    $"{sayi} sayisi bir tamsayi degildir."); //!=