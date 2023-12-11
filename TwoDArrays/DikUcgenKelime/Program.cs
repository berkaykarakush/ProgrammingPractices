// girdi
Console.Write("Kelime giriniz: ");
string text = Console.ReadLine();
// kelimenin icinde dolas
for (int i = 0; i < text.Length; i++)
    // her dongude bir harf arttir ve yaz
    Console.WriteLine(text.Substring(0, i+1));
