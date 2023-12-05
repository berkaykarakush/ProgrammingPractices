// n elemanli a dizisinin elemanlarini b dizisine tersten ata
Console.Write("Eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// n elemanli dizi tanimla
int[] array =  new int[n];
int[] reverseArray = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"{i}.Eleman: ");
    // alinan degerleri dizinin ilgili indeksine ata
    array[i] = int.Parse(Console.ReadLine());
}
//tersten yazdirma
for (int i = 0; i < n; i++)
{
    reverseArray[i] = array[n-1-i];
    Console.WriteLine($"{i + 1}.Eleman: {reverseArray[i]}");
}

