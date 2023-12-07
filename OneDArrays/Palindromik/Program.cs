// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine().ToLower();
string reverse =  "";
// cumlenin tersini al
for (int i = sentence.Length - 1; i >= 0; i--)
    reverse += sentence[i];
// cikti
Console.WriteLine(sentence == reverse ? "Palindrom":"Palindrom degil");