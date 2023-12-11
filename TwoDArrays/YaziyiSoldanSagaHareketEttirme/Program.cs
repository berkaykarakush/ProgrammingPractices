// girdi
Console.Write("Kelime girini: ");
string text = Console.ReadLine();
// yaziyi soldan saga oteler 30 kere
for (int i = 0; i < 30; i++)
{
    // pointeri ayni hizara saga oteler
    Console.SetCursorPosition(i, 1);
    // yaz
    Console.Write(text);
    // 1 sn bekle
    Thread.Sleep(1000);
    // temizle
    Console.Clear();
}
