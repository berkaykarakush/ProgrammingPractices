// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine().ToLower();
// tek ise, bosluk ekleyerek cift olmasi saglar
sentence += (sentence.Length % 2 != 0) ? " " : "";
// islemin yapildigi dongu
for (int i = 0; i < sentence.Length; i++)
    // i cift ise i'den sonraki harfi getir, i tek ise i'den onceki harfi getir
    Console.Write((i % 2 == 0) ? sentence[i+1] : sentence[i -1]);

