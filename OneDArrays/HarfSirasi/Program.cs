// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine().ToLower();
// cumle icinde gezelim
for (int i = 0; i < sentence.Length; i++)
    Console.Write($"{sentence[i]} : {i+1}\t");
