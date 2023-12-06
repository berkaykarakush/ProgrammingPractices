//girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine();
string result = "";
// islemin yapildigi dongu
for (int i = 0; i < sentence.Length; i++)
{
    // 0-1, 2-3 degerleri uzerinden ilk iki sonraki iki ayrimi yapmamizi saglar
    // ilk iki harfi buyut 0-1, sonraki iki harfi kucult 2-3
    result += (i % 4 < 2) ? char.ToUpper(sentence[i]) : char.ToLower(sentence[i]);
}
//cikti
Console.WriteLine($"Yeniden: {result}");
