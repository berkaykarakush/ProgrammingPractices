// girdi
Console.Write("Sayi giriniz: ");
string input = Console.ReadLine();
// baslik
Console.WriteLine("Basamaklar\n---------------");
// sayiyi parcala
for (int i = input.Length - 1;i >= 0; i--)
{
    // basamaklarina gore basamak degerini yaz
    Console.WriteLine($"{Math.Pow(10, input.Length - 1 - i)} => {input[i]}");
}
