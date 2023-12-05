// uzunlugu ve dizi tanimla
Console.Write("Giris isaretinin uzunlugu: ");
int n1 = int.Parse(Console.ReadLine());
double[] array1 = new double[n1];
// elemanlari al
for (int i = 0; i < n1; i++)
{
    Console.Write($"{i + 1}.Eleman: ");
    array1[i] = int.Parse(Console.ReadLine());
}
// uzunlugu al ve dizi tanimla
Console.Write("Birim durtu cevabinin uzunlugu: ");
int n2 = int.Parse(Console.ReadLine());
double[] array2 = new double[n2];
// elemanlari al
for (int i = 0; i < n2; i++)
{
    Console.Write($"{i + 1}.Eleman: ");
    array2[i] = int.Parse(Console.ReadLine());
}
// dizi tanimla
double[] y = new double[n1 + n2 - 1];
// Konvulsuyon isleminin yapildigi kisim
for (int i = 0; i < n1 + n2 - 1; i++)
{
    int k = i;
    y[i] = 0;
    // konvulsuyon islemi 
    for (int j = 0; j < n2; j++)
    {
        if ((k >= 0) && (k < n1))
            y[i] += array1[k] * array2[j];
        k--;
    }
    // cikti
    Console.Write($"{y[i]} \t");
}