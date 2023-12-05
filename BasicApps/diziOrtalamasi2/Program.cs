 //pozitif iki x,y sayisinin aritmetik-geometrik, aritmetik-harmonik ve geometrik-harmonik ortalamalarini iterasyon yoluyla hesaplama
#region Degisken tanimlama ve ilk deger atama
float aritmetikGeometrikOrt = 0f;
float aritmetikHarmonikOrt = 0f;
float geometrikHarmonikOrt = 0f;
float birinciSayi = 0f;
float ikinciSayi = 0f;
int iterasyonSayisi = 0;
float aga1 = 0f;
float agg1 = 0f;
float ahh1 = 0f;
float aha1 = 0f;
float ghg1 = 0f;
float ghh1 = 0f;
float aga = 0f;
float agg = 0f;
float ahh = 0f;
float aha = 0f;
float ghg = 0f;
float ghh = 0f;

#endregion

Console.Write("Ilk sayi degerini giriniz: ");//ilk sayi degerini iste
birinciSayi = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Ikinci sayi degerini giriniz: ");
ikinciSayi = float.Parse(Console.ReadLine());

Console.Write("Iterasyon sayisini giriniz: ");
iterasyonSayisi = int.Parse(Console.ReadLine());

Console.WriteLine("iterasyon sayisi \tAritmetik-Geometrik Ortalama \tAritmetik-Harmonik Ortalama \tGeometrik-Harmonik Ortalama \n---------------- \t---------------------------- \t--------------------------- \t---------------------------");

aga1 = (birinciSayi + ikinciSayi) / 2; //aga1 = (x*y)/2 
agg1 = (float)Math.Pow((birinciSayi * ikinciSayi), (0.5)); //agg1 = (x*y)^0.5
ahh1 = 2 / (1 / birinciSayi + 1 / ikinciSayi);//ahh1 = 2/(1/x+1/y)
aha1 = aga1;
ghg1 = agg1;
ghh1 = ahh1;
Console.WriteLine($"1 \t\t\t{aga1,0:F3} {agg1,0:F3} \t\t\t{aha1,0:F3} {ahh1,0:F3} \t\t\t{ghg1,0:F3} {ghh1,0:F3}");

                                                                                                    
for (int i = 2; i <= iterasyonSayisi; i++)
{
    aga = (aga1 + agg1) / 2;
    agg = (float)Math.Pow((aga1 * agg1), (0.5));
    aha = (aha1 + ahh1) / 2;
    ahh = 2 / (1 / aha1 + 1 / ahh1);
    ghg = (float)Math.Pow((ghg1 * ghh1), (0.5));
    ghh = 2 / (1 / ghg1 + 1 / ghh1);

    Console.WriteLine($"{i} \t\t\t{aga,0:F3} {agg,0:F3} \t\t\t{aha,0:F3} {ahh,0:F3} \t\t\t{ghg,0:F3} {ghh,0:F3}");

    aga1 = aga;
    agg1 = agg;
    aha1 = aha;
    ahh1 = ahh;
    ghg1 = ghg;
    ghh1 = ghh;
}