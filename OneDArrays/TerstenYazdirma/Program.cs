// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine();
Console.Write("Cumlenin Tersten Yazimi: ");
// cumlenin sonundan basina dogru dongu
for (int i = sentence.Length-1; i >= 0; i--)
    Console.Write($"{sentence[i]}");