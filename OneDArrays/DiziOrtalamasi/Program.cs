// n elemanli dizinin ortalamalari
Console.Write("Eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// n elemanli dizi tanimla
double[] array =  new double[n];
// dizinin elemanlarini al
for (int i = 0; i < n; i++)
{
    Console.Write($"{i+1}.Eleman: ");
    array[i] = double.Parse(Console.ReadLine());
}
// degisken tanimlama
double result = 0, multiply = 1, result2 = 0, harmonicResult = 0;
// ortalama hesaplari
for (int i = 0; i < n; i++)
{
    result += array[i];
    multiply *= array[i];
    harmonicResult += 1/array[i];
    result2 += array[i] * array[i];
}
Console.WriteLine($"Aritmetik ortalama: {result / n}");
Console.WriteLine($"Geometrik ortalama: {Math.Pow(multiply, (1.0/n))}");
Console.WriteLine($"Harmonik ortalama: {n / harmonicResult}");
Console.WriteLine($"Kontraharmonik ortalama: {result2 / result}");


