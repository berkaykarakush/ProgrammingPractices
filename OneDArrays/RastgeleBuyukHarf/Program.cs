Console.Write("Cumle: ");
// Girdi
string sentence = Console.ReadLine();
Console.Write("Tersten: ");
for (int i = sentence.Length - 1; i >= 0; i--)
{
    // rastgele sayi uret
    int random = new Random().Next();
    // cift ise buyut, tek ise kucult
    char charachter = (random % 2 == 0) ? char.ToUpper(sentence[i]) : char.ToLower(sentence[i]);
    Console.Write(charachter);
}
