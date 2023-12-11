string text = "BURSA";
for (int i = 0; i < 10; i++)
{
    // bastan 2 karakter oteler
    Console.SetCursorPosition(i,2*i+1);
    Console.Write(text);
    // sondan 2 karakter oteler
    Console.SetCursorPosition(i, 46 - 2 * i);
    Console.Write(text);
}
