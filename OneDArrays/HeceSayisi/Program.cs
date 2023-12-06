// degerlerin alinmasi
Console.Write("Cumleyi giriniz:");
string sentence = Console.ReadLine();
Console.Write("Heceyi giriniz: ");
string syllable = Console.ReadLine();
// sayac
int count = 0;
// poziyon bilgisinin tutulacagi dizi
int[] positions = new int[sentence.Length];
// islemin yapilacagi dongu
for (int i = 0; i <= sentence.Length - syllable.Length; i++)
{
	// alinan parca ile hece ayni ise sayaci arttir ve posizyonu kaydet
	if (sentence.Substring(i,syllable.Length).Equals(syllable, StringComparison.OrdinalIgnoreCase))
	{
		count++;
		positions[count - 1] = i + 1;
	}
}
// cikti
Console.WriteLine($"Count: {count}");
for (int i = 0;i < count; i++)
	Console.WriteLine($"{positions[i]} |");