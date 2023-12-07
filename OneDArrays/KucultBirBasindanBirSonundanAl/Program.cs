// girdi
Console.Write("Cumle buyuk harflerle: ");
// cumleyi kucult
string sentence = Console.ReadLine().ToLower();
// tersten
for (int i = sentence.Length - 1; i >= 0; i--)
    Console.Write(sentence[i]);
// normal
for (int i = 0; i < sentence.Length; i++)
    Console.Write(sentence[i]);