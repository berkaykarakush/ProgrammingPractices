// girdi
Console.Write("Cumleyi giriniz: ");
string text = Console.ReadLine();
// girdi
Console.Write("harfi giriniz: ");
char character = Convert.ToChar(Console.ReadLine());
// sayac
int count = 0;
// yerlerin tutulacagi dizi
int[] places = new int[100];
// kontrolun yapildigi dongu
for (int i = 0; i < text.Length; i++)
	// esit ise 
	if (text[i] == character)
	{
		// sayiyi arttir
		count++;
		// yeri kaydet
		places[count - 1] = i + 1;
	}
// cikti
// harf sayisini yaz
Console.Write($"Harf Sayisi: {count} \nYerleri: ");
// yerli yaz
for (int i = 0; i < count; i++)
    Console.Write($"{places[i]} | ");
