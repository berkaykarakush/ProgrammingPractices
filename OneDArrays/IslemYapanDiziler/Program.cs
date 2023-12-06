// eleman sayisini al
Console.WriteLine("Dizilerin eleman sayisi: ");
int n = int.Parse(Console.ReadLine());
// dizileri tanimla
double[] arrayA =  new double[n];
double[] arrayB =  new double[n];
// dizi elemanlarini al
for (int i = 0; i < n; i++)
{
    Console.Write($"1.Dizinin {i+1}. Elemani: ");
    arrayA[i] = double.Parse(Console.ReadLine());
    Console.Write($"2.Dizinin {i+1}. Elemani: ");
    arrayB[i] = double.Parse(Console.ReadLine());
}
// degisken tanimla ve ilk deger ata
double t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0, c1 = 1, c2 = 1;
// gerekli hesaplamarin yapildigi dongu
for (int i = 0; i < n; i++)
{
    // formulun parcalanmis halleri
    t1 += (arrayA[i] * arrayA[i]);
    t2 += arrayA[i] * arrayB[i];
    t3 += arrayB[i];
    t4 += arrayA[i];
    t5 += Math.Log(arrayB[i]);
    c1 *= Math.Sqrt(arrayB[i]);
    c2 *= arrayA[i];
}
// formulun birlestirilmesi
double result = (t1 + 2 * t2 + t3 * t3 + 3 * c1) / (Math.Sqrt(t4) + n * t5 - c2);
// cikti
Console.WriteLine($"Islemin Sonucu: {result}");
