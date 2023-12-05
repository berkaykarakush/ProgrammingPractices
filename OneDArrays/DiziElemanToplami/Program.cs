//n degerini al
Console.Write("Eleman sayisini giriniz: ");
int n = int.Parse(Console.ReadLine());
// n elemanli dizi olustur
int[] array = new int[n];
// toplam degerini tutan degisken
int result = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"{i+1}. Eleman:");
    //girilen degeri dizinin ilgili indeksine ata
    array[i] = int.Parse(Console.ReadLine());
    //elemanlari topla
    result += array[i];    
}
Console.WriteLine($"Toplam:{result}");
