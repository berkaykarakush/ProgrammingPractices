// a dizisindeki negafitleri bir diziye pozitifleri bir diziye topla
Console.Write("Dizinin eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// dizi tanimlama ve degerlerin alinmasi
double[] array = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}. Eleman: ");
    array[i] = double.Parse(Console.ReadLine());    
}
// degisken ve dizi tanimlama
double x = 0, y = 0;
double[] arrayP = new double[n];
double[] arrayN = new double[n];
// kontrol islemlerinin yapildigi dongu
for (int i = 0; i < n; i++)
{
    if (array[i] != 0)
    {
        // possitive
        if (array[i] > 0)
        {
            x++;
            arrayP[i] = array[i];
            Console.WriteLine($"Pozitif {i+1}.Eleman: {arrayP[i]}");
        }
        // negatif
        else
        {
            y++;
            arrayN[i] = array[i];
            Console.WriteLine($"Negatif {i+1}.Eleman: {arrayN[i]}");
        }
    }
}

