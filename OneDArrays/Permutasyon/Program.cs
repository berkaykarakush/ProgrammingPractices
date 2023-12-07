// girdi
Console.Write("Kelime: ");
string word = Console.ReadLine();
Console.WriteLine($"Permutasyonlar: ");
// metot cagirimi
Permutasyon(word.ToCharArray(), 0, word.Length - 1);
// verilen keliminen olasi kombinasyonlarini hesalayip donen metot
void Permutasyon(char[] chars, int left, int right)
{
    // degerler esit ise yaz
    if (left == right)
        Console.WriteLine(chars);
    // degerler esit degil ise 
    else
        for (int i = left; i <= right; i++)
        {
            char g= chars[left];
            chars[left] = chars[i];
            chars[i] = g;
            // rekursif
            Permutasyon(chars, left+1, right);
            g = chars[left];
            chars[left] = chars[i];
            chars[i] = g;
        }
}