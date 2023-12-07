// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine().ToLower();
// virgulleri bosluk ile degistir
sentence = sentence.Replace(',', ' ');
// bosluk karakterlerinden ayirma islemi gerceklestir
string[] words = sentence.Split(" ");
// kelime sayisi
Console.Write($"Kelime Sayisi: {words.Length}");