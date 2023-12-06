// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine();
// cikti
Console.Write("Tersten: ");
// islemin yapildigi dongu
for (int i = sentence.Length - 1; i >= 0; i--)
{
    // cift ise lower, tek ise upper
    char character =(i % 2 == 0) ? char.ToLower(sentence[i]) : char.ToUpper(sentence[i]);
    Console.Write(character);
}
