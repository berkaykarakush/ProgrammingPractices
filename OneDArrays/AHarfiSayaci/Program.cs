// icinde a harfi olan kelime sayisi
Console.Write("Cumle: ");
// cumleyi al icinde , ya da . varsa ' ' ile degistir ve kucult
string sentence = Console.ReadLine().ToLower().Replace(',',' ').Replace('.', ' ');
// bosluklardan ayir ayrica bos karakterleri sil diziye ata
string[] words =  sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int counter = 0;
// dizi icinde don
for (int i = 0; i < words.Length; i++)
    // a iceren kelime varsa sayaci arttir
    if (words[i].Contains("a"))
        counter++;
// sonuc
Console.WriteLine($"Icinde a gecen kelime sayisi: {counter}");