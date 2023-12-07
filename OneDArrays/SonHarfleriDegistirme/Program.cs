// girdi
Console.Write("Cumle: ");
string sentence = Console.ReadLine().ToLower();
Console.Write("Gizlenecek sondan karakter sayisi: ");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < sentence.Length; i++)
    // i degeri kucukse acik harf, i degeri buyuk esitse acik harf gozukecektir
    Console.Write((i >= sentence.Length - count) ? "*" : sentence[i]) ;
