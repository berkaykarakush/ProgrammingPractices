// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine().ToLower();
// cumle icinde dolas
for (int i = 0; i < sentence.Length; i++)
{
    // -87 ile sifrele ve int'e donustur
    int s = sentence[i] - 87;
    // int/sifreli degerini goster
    Console.Write($"{s} = ");
}
