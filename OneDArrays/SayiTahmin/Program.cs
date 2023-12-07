// dizi tanimla
int[] numbers =  new int[6];
Random random = new Random();
// rastgele sayi atamasi
for (int i = 0; i < numbers.Length; i++)
    numbers[i] = random.Next(50);
// sayac
int counter = 0;
// her rakam icin tekrarla
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{i+1}. Sayi: ");
    // esitlik kontrolu, esitse sayaci arttir
    if (int.Parse(Console.ReadLine()) == numbers[i])
        counter++;
}
// cikti
Console.WriteLine($"Dogru Sayisi: {counter}");
