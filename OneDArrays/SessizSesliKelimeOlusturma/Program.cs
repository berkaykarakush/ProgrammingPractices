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
	for (int j = 0; j < vowels.Length; j++)
	{
		if (sentence[i] == vowels[j])
		{
            sentenceV += sentence[i];
			isVowel = true;
			break;
        }
    }
	if(!isVowel)
        sentenceC += sentence[i];
}
Console.WriteLine($"Sesli: {sentenceV} \nSessiz: {sentenceC}");
