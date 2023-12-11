// girdi
Console.Write("Kelime giriniz: ");
string text = Console.ReadLine();
// 24 kere islem tekrarla
for (int i = 24; 1 < i; i--)
{
    // pointeri hareket ettir
    Console.SetCursorPosition(24,i);
    // metni yaz
    Console.Write(text);
    // 1 sn bekle
    Thread.Sleep(1000);
    // konsol u temizle
    Console.Clear();
}
