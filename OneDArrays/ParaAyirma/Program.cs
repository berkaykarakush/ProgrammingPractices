// banknotlar
int[] moneys = { 200, 100, 50, 20, 10, 5, 1};
// girdi
Console.Write("Miktar: ");
int money = int.Parse(Console.ReadLine());
// kontrol
for (int i = 0; i < moneys.Length; i++)
{
    // kac adet oldugunu hesapla
    int count = money / moneys[i];
    // sifira esit degilse
    if (count != 0)
        Console.Write($"{count} Adet {moneys[i]} TL | ");
    // kalan parayi hesapla
    money = money % moneys[i];
}
