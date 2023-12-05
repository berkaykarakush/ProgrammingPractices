//yil<4000 icin artik yil hesaplayan program 
Console.Write("4000'den kucuk bir deger giriniz. \nYil: ");//bilgi metni
int yil = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

// (yil mod 4 = 0) VE ((yil mod 100 <> 0) VEYA (yil mod 400 = 0))
Console.WriteLine(( (yil % 4 == 0) && ((!(yil % 100 == 0)) || (yil % 400 == 0)) ) ? $"{yil} yili bir artik yildir.": //evet
                                                                            $"{yil} yili bir artik yil degildir.");//hayir
