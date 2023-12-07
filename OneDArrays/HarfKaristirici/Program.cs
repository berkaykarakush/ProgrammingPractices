// girdi
Console.Write("Cumle :");
string sentence = Console.ReadLine();
string newSentence = "";
Random random = new Random();
// harfleri karisitir
for (int i = sentence.Length; i > 0; i--)
    newSentence+= sentence[random.Next(i)];
// cikti
Console.WriteLine($"Yeni cumle:{newSentence} ");