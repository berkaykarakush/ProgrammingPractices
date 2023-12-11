// girdi
Console.Write("Kelime giriniz: ");
string text = Console.ReadLine();
// konsolu temizle
Console.Clear();
// metni ekrana bas
Console.WriteLine(text);
// metin icinde don
for (int i = 0; i < text.Length; i++)
{
    // girilen metnin tersini al
    string reverse = new string(text.Reverse().ToArray());
    // pointeri hareket ettir
    Console.SetCursorPosition(i+text.Length, i+1);
    // eksilen harfi goster
    Console.WriteLine(reverse[i]);
    // 1 sn bekle
    Thread.Sleep(1000);
}