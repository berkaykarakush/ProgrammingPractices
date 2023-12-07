// girdi
Console.Write("Sifreli cumle: ");
string sentence = Console.ReadLine();
for (int i = 0; i < sentence.Length; i++)
    // cift ise sonraki harfi tek ise onceki harfi getir 
    Console.Write((i % 2 == 0) ? sentence[i+1] : sentence[i-1]);

