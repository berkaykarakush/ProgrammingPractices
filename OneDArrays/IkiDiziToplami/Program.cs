// n elemanli A ve B dizilerinin toplamini C dizisine yazdir

Console.Write("1. dizinin eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// array1 olusturuldu
int[] array1 = new int[n];
// array1 degerlerini ata
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"{i+1}. Eleman:");
    array1[i] = int.Parse(Console.ReadLine());
}

Console.Write("2.Dizinin eleman sayisini giriniz: ");
n = int.Parse(Console.ReadLine());
// arra2 olusturuldu
int[] array2 = new int[n];
// array2 degerlerini ata
for (int i = 0; i < array2.Length; i++)
{
    Console.Write($"{i+1}. Eleman:");
    array2[i] = int.Parse(Console.ReadLine());
}

// array1 + array2
int[] array3 = new int[array1.Length + array2.Length];
for (int i = 0; i < array3.Length; i++)
{
    array3[i] = array1[i] + array2[i];
    Console.WriteLine($"{array3[i]}");
}
