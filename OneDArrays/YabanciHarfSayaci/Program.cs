Console.Write("Cumleyi giriniz: ");
string sentence = Console.ReadLine().ToUpper();
int count = 0;
for (int i = 0; i < sentence.Length; i++)
{
    int s = sentence[i];
    if (s >= 90)
        count++;
}
Console.WriteLine($"Yabanci Harf Sayisi: {count}");
