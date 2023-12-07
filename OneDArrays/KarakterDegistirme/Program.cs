// girdi
Console.Write("Cumleyi giriniz: ");
string sentence  = Console.ReadLine();
Console.Write("Degistirmek istediginiz harfi giriniz: ");
char charachter = char.Parse(Console.ReadLine());
Console.Write("Yeni harfi giriniz: ");
char newCharachter = char.Parse(Console.ReadLine());
// her harfi dolas
for (int i = 0; i < sentence.Length; i++)
{
    // eslesme var ise degistir
    if (sentence[i] == charachter)
        sentence = sentence.Replace(charachter, newCharachter);
}
// cikti
Console.WriteLine($"Yeni cumle: {sentence}");