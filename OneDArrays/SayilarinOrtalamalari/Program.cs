// pozitif iki x, y sayisinin aritmetik-geometrik, aritmetik-harmonik ve geometrik-harmonik ortalamalari iterasyon ile hesaplanmaktadir
Console.Write("Sayi 1: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Sayi 2: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Iterasyon sayisi: ");
double n = double.Parse(Console.ReadLine());

// arithmetic geometric average
double aga1 = (num1 + num2) / 2;
double agg1 = Math.Pow((num1 * num2), 0.5);
// arithmetic harmonic average
double ahh1 = 2 / (1/num1+1/num2);
double aha1 = aga1;
// geometrik harmonic average
double ghg1 = agg1;
double ghh1 = ahh1;
// baslik
Console.WriteLine($"Iterasyon Ort \t Aritmetik-Geometrik Ort \t Aritmetik-Harmonik ort \t Geometrik-Harmonik Ort");
// satir cizgisi
Console.WriteLine($"-------------- \t ---------------------- \t ---------------------- \t ----------------------");
// baslangic degerleri
Console.WriteLine($"1 \t\t  {aga1:F3} {agg1:F3}  \t\t  {aha1:F3} {ahh1:F3} \t\t\t {ghg1:F3} {ghh1:F3}");

for (int i = 2; i < n; i++)
{
    // hesaplama islemleri
    double aga = (aga1 + agg1) / 2;
    double agg = Math.Pow((aga1 * agg1), 0.5);
    double aha = (aha1 + ahh1) / 2;
    double ahh = 2 / (1/aha1 + 1/ahh1);
    double ghg = Math.Pow((ghg1 * ghh1), 0.5);
    double ghh = 2 / (1/ghg1 + 1/ghh1);
    // cikti
    Console.WriteLine($"{i}\t\t  {aga:F3} {agg:F3} \t\t  {aha:F3} {ahh:F3} \t\t  {ghg:F3} {ghh:F3}");
    aga1 = aga;
    agg1 = agg;
    aha1 = aha;
    ahh1 = ahh;
    ghg1 = ghg;
    ghh1 = ghh;
}
