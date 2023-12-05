// katsayilari girilen n. dereceden polinomun x = b degerini Horner Yontemi ile hesaplayalim
Console.Write("Katsayi degeri: ");
int n = int.Parse(Console.ReadLine());
//dizi tanimlama
double[] array = new double[n+1];
for (int i = 0; i < n + 1; i++)
{
    // kullanicidan katsayilari al
    Console.Write($"x^{i} nin katsayisi: ");
    array[i] = double.Parse(Console.ReadLine());
}
// x degerini al
Console.Write("Hesaplanacak x degeri: ");
double b = double.Parse(Console.ReadLine());
// horner formulu ile hesaplama
double result = array[n];
for (int i = n - 1; i >= 0; i--)
    result = result * b + array[i];
// output
Console.WriteLine($"y({b:F3}) = {result}");
