// degerlerin alinmasi ve degisken tanimlama
Console.Write("Ogrenci sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
double sum = 0.0;
// degerlerin alinmasi
for (int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}. Ogrenci: ");
    int note = int.Parse(Console.ReadLine());
    // 0-100 arasinda degilse tetikle
    if (!(note > 0) || !(note <= 100))
    {
        Console.WriteLine("0-100 arasinda bir deger girmeniz gerekmektedir.");
        return;
    }
    // 0-100 arasinda ise
    array[i] = note;
    // notlarin toplami
    sum += array[i];
}
// ortalama hesaplama
double avg = sum / n;
// tek tek notlarin kontrol edilmesi
for (int i = 0; i < n; i++)
{
    // ortalama uzeri
    if (array[i] > avg)
        Console.WriteLine($"{i + 1}. Ogrenci: Gecti");
    // ortalama alti
    else
        Console.WriteLine($"{i + 1}. Ogrenci: Kaldi");
}

