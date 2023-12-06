Console.Write("Dizilerin eleman sayisi: ");
int n = int.Parse(Console.ReadLine());
// Dizi tanimlamasi ve degerlerin alinmasi
double[] arrayX = new double[n];
double[] arrayY = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write("X dizisinin ilk elemani: ");
    arrayX[i] = double.Parse(Console.ReadLine());
    Console.Write("Y dizisinin ilk elemani: ");
    arrayY[i] = double.Parse(Console.ReadLine());
}
// degisken tanimlama ve ilk deger atama
double num1 = 0.0, num2 = 0.0, num3 = 0.0, num4 = 0.0;
// ontrol islemlerinin yapildigi dongu
for (int i = 0; i < n; i++)
{
    // 1. bolge
    if ((arrayX[i] > 0) && (arrayY[i] > 0))
        num1++;
    // 2.bolge
    if ((arrayX[i] < 0) && (arrayY[i] > 0))
        num2++;
    // 3. bolge
    if ((arrayX[i] < 0) && (arrayY[i] < 0))
        num3++;
    // 4. bolge
    else 
        num4++;
}
// cikti
Console.WriteLine($"1. bolge: {num1} \n2. bolge: {num2} \n3. bolge: {num3} \n4. bolge: {num4}");
