// Kullanıcıdan bir kelime al
Console.Write("Kelime:");
string word = Console.ReadLine();
// Kursorun görünürlüğünü kapat
Console.CursorVisible = false;
Random random = new Random();
// Konsolu temizle
Console.Clear();

// Klavyeden herhangi bir tuşa basılmadığı sürece devam et
while (!Console.KeyAvailable)
{
    // Rastgele bir uzunluk seç
    int length = random.Next(1, word.Length);
    // Kelimenin belirtilen uzunluğuna kadar olan kısmını al
    string text = word.Substring(0, length);
    // genislik degeri
    int x = random.Next(Console.WindowWidth);
    // yukseklik degeri
    int y = random.Next(Console.WindowHeight);
    Console.SetCursorPosition(x,y);
    // Belirlenen konumda rastgele metni ekrana yaz
    Console.WriteLine(text);
    // 1 s bekle
    Thread.Sleep(1000);
    // Kursorun görünürlüğünü tekrar aç
    Console.CursorVisible = true;
}