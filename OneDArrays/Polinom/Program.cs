// katsayilari girilen n. dereceden polinomun x = b icin degeri 
Console.Write("Katsayi degeri: ");
int n = int.Parse(Console.ReadLine());
//dizi tanimlama
double[] array = new double[n+1];
for (int i = 0; i < n+1; i++)
{
    Console.Write($"x^{i} nin katsayisi: ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Hesaplanacak x degeri: ");
double b = double.Parse(Console.ReadLine());
// an*xn+an-1*xn-1+ seklinde polinom hesaplamasi yapiyoruz
double result = array[0];
for (int i = 1; i <= n; i++)
    result += array[i] * Math.Pow(b,i);

Console.WriteLine($"y({b:F3}): {result:F3}");