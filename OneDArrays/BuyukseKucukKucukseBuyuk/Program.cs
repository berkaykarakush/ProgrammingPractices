// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine();

// yeni degeri tutacak degisken
string result = "";
foreach (var s in sentence)
    // sayi buyukse kucult, kucukse buyut
    result += char.IsUpper(s) ? char.ToLower(s) : char.ToUpper(s);
// cikti
Console.WriteLine($"Yeniden: {result}");