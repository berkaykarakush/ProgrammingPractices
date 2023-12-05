// eleman sayisi ve katsayiyi al
Console.Write("Eleman sayisi: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Katsayi: ");
int k = int.Parse(Console.ReadLine());

// n elemanl dizi tanimla
int[] array = new int[n];
int[] array2 = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i+1}. Eleman: ");
    // dizi elemanlarini al
    array[i] = int.Parse(Console.ReadLine());
    // k ile dizinin elemanlarini carp ve yeni diziye ata
    array2[i] = array[i] * k;
}
// output
for (int i = 0;i < array2.Length; i++)
    Console.WriteLine($"{array2[i]}");
