// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine().ToLower();
// virgulleri bosluk ile degistir
sentence = sentence.Replace(',', ' ').Replace('.', ' ');
// bosluk karakterlerinden ayirma islemi gerceklestir
string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// kelime sayisi
Console.Write($"Kelime Sayisi: {words.Length}");