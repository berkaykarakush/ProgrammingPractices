// n elemanli a ve b dizilerinin skaler carpimi
Console.Write("Eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// n elemanli diziler
int[] array = new int[n];
int[] array2 = new int[n];
int result = 0;
for (int i = 0; i < n; i++)
{
    // 1. dizinin elemanlarini al
    Console.Write($"1. dizinin {i+1}.Elemani: ");
    array[i] = int.Parse(Console.ReadLine());
    // 2. dizinin elemanlarini al
    Console.Write($"2. dizinin {i+1}.Elemani: ");
    array2[i] = int.Parse(Console.ReadLine());

    // onceki toplam + 1. eleman * 2. eleman seklinde hesaplama
    result += array[i] * array2[i];
}
// output
Console.WriteLine($"Skaler Carpim: {result}");
