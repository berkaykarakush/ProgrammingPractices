//metre cinsinden girilen degeri donusturme
Console.Write("Donusturmek istediginiz degeri giriniz (m): ");//bilgi metni
float deger = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("\nDonusum yapmak istediginiz birimi seciniz \n1-mm \n2-cm \n3-dm \n4-km \nseciminiz: ");
int sec = int.Parse(Console.ReadLine());

//Switch Expression 
float sonuc =sec switch{
    1 => sonuc = deger * 1000, //mm donusumu
    2 => sonuc = deger * 100, //cm donusumu
    3 => sonuc = deger * 10, //dm donusumu
    _ => sonuc = deger/1000 //km donusumu
};

Console.WriteLine($"sonuc:{sonuc}");