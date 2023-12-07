// dizi tanimlama
char[] tr = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü' };
char[] en = { 'c', 'g', 'i', 'o', 's', 'u' };
// girdi
Console.Write("Cumleyi giriniz: ");
string sentence = Console.ReadLine();
// cumle icinde don
for (int i = 0; i < sentence.Length; i++)
	// dizilerin icinde don
	for (int j = 0; j < tr.Length; j++)
		// tr harfi varsa en harfi ile degistir, yoksa bir sey yapma
		sentence = sentence[i] == tr[j] ? sentence.Replace(tr[j], en[j]) : sentence.ToString();
// cikti
Console.Write($"Yeni cumle: {sentence}");
