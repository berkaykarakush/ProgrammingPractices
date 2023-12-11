string text = "TORONTO";
// her karakter icin 
for (int i = 0; i < text.Length; i++)
{
    // belirli bir konuma imleci ayarla
    Console.SetCursorPosition(i, i);
    // ilgili karakteri al
    string t = text.Substring(i,1);
    // ilk isim / ikinci kisim / ucuncu kisim seklinde cikti olusturur
    Console.Write($"{t.PadRight(text.Length-i)}  {t.PadRight(text.Length-i)} {t}");
}