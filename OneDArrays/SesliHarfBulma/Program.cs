// sesli harfler
char[] letters = {'a','e','i', 'o', 'u'};
// girdi
Console.Write("Cumleyi giriniz: ");
string sentence = Console.ReadLine().ToLower();
int counter = 0;
// yerlerin tutulacagi dizi
int[] places = new int[sentence.Length];
// islemlerin yapildigi dongu
for (int i = 0; i < sentence.Length; i++)
{
    // harf karsilastirmasi
    for (int j = 0; j < letters.Length; j++)
    {
        // dogru ise sayaci arttir ve yer bilgisini al
        if (sentence[i] == letters[j])
        {
            counter++;
            places[counter] = i+1;
        }
    }
}
Console.WriteLine($"{counter} tane sesli harf vardir. \nYerleri: ");
// yer bilgisini yazdir
for (int i = 0; i <= counter; i++)
    if (places[i] != 0)
        Console.Write($"{places[i]} ");
