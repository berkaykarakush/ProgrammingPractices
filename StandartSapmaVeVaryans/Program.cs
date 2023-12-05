// n elemanli bir dizinin standart sapmasi ve varyansi
Console.Write("Dizinin eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// dizi tanimlama
int[] array = new int[n];

// degisken tanimlama
double aritmeticAvr = 0, result = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"{i+1}. Eleman: ");
    // dizi elemanlarini al
    array[i] = int.Parse(Console.ReadLine());
    // ortalama ve girilen degerleri topla
    aritmeticAvr += array[i];
}
// toplanan degeri eleman sayisina bolerek ortalamayi elde et
aritmeticAvr /= n;
// toplam hesaplama
for (int i = 0; i < n; i++)
    result += Math.Pow((array[i] - aritmeticAvr),2);

// varyans hesaplama
double varience = result / n;
// standart sapma hesaplama
double standardDeviation = Math.Pow(varience,0.5);

Console.WriteLine($"Standard Deviation = {standardDeviation:F3} \nVarience = {varience:F3}");