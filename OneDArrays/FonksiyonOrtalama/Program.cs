// f(t) = a.Sin(2pift) geriliminin ortalama ve etkin degerleri
Console.Write("f(t) = a.Sin(2pift) icin \na degeri: ");
double a = double.Parse(Console.ReadLine());
Console.Write("f degeri: ");
double f = double.Parse(Console.ReadLine());
Console.Write("n degeri: ");
double n  = double.Parse(Console.ReadLine());
// degisken tanimlama
double p = 1 / f, t1 = 0.0, t2 = 0.0, t3 = 0.0, t4 = 0.0, h = p / n;
// deger hesaplamalari
for (int k = 0; k < n; k++)
{
    double t = k * h;
    double g1 = a * Math.Sin(2 * Math.PI * f * t);
    double g2 = a * Math.Sin(2 * Math.PI * f * (t + h));
    t1 += (g1 + g2) * h / 2;
    t2 =+ (g1 * g1 + g2 * g2) * h / 2;
    t3 += g1;
    t4 += g1 * g1;
}
// ortalama hesaplamalari
double fOrtS = t1 / p;
double fRmsS = Math.Sqrt(t2 / p);
double fOrtA = t3 / n;
double fRmsA = Math.Sqrt(t4 / n);
// cikti
Console.WriteLine($"Ortamalama Deger \nDA: {fOrtA} \nDC: {fOrtS} \nEtkin Deger(RMS) \n{fRmsA} \t{fRmsS}");