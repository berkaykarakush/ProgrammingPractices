// girdi
Console.Write("Cumle :");
// tum kelimeyi buyuk olarak al, sonradan buyutmek icin ugrasma
string sentence = Console.ReadLine().ToUpper();
for (int i = 0; i < sentence.Length; i++)
    // 2'den kucukse ilk 2, 2'den buyuksek sonraki 2 anlaminda
    Console.Write((i % 4 < 2) ? sentence[i] :"*");