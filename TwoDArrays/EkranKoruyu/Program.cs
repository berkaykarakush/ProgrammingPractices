// Kursorun görünürlüğünü kapat
Console.CursorVisible = false;
// Rastgele sayılar oluşturmak için Random sınıfı kullanılır
Random random = new Random();
// Klavyeden herhangi bir tuşa basılmadığı sürece devam et
while (!Console.KeyAvailable)
{
    // Ekran genişliği içinde rastgele bir x ve y koordinatı seç
    int x = random.Next(Console.WindowWidth);
    int y = random.Next(Console.WindowHeight);
    // Rastgele renk seçimi yap
    ConsoleColor color = (ConsoleColor)random.Next(Enum.GetValues(typeof(ConsoleColor)).Length);
    Console.ForegroundColor = color;
    // Seçilen konuma '*' karakterini yaz
    Console.SetCursorPosition(x, y);
    Console.WriteLine('*');
    // 1 saniye beklet
    Thread.Sleep(1000);
    // Rengi sıfırla
    Console.ResetColor();
    // Konsolu temizle
    Console.Clear();
}
// Kursorun görünürlüğünü tekrar aç
Console.CursorVisible = true;
