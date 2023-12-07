// sesli harfler
char[] vowels = {'a','e','i','o','u'};
// girdi
Console.Write("Cumleyi giriniz: ");
string sentence = Console.ReadLine().ToLower();
// yeni cumleleri tutacak degiskenler
string sentenceV = "", sentenceC = "";
// kontrol
for (int i = 0; i < sentence.Length; i++)
{
	bool isVowel = false;
	// cumle icinde dolas
	for (int j = 0; j < vowels.Length; j++)
	{
		// esitse
		if (sentence[i] == vowels[j])
		{
			// sesliye ekle
            sentenceV += sentence[i];
			isVowel = true;
			break;
        }
    }
	// sessize ekle
	if(!isVowel)
        sentenceC += sentence[i];
}
// cikti
Console.WriteLine($"Sesli: {sentenceV} \nSessiz: {sentenceC}");
