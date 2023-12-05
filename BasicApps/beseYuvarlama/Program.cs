//girilen tamsayiyi, kendisinden kucuk en yakin 5'in katina yuvarlayan program 
Console.Write("Yuvarlamak istediginiz sayiyi giriniz: ");//bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

Console.WriteLine($"En yakin 5'in katina yuvarlanmis hali: {(Math.Ceiling((double)(((sayi * 2) / 10) * 5)))}"); // ((sayi*2)/10)*5