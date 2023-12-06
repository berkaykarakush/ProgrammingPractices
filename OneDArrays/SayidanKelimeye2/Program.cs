// sayi karsiliklarinin tanimlanmasi
string[] ones = {"","one","two","three","four","five","six","seven","eight","nine"}; 
string[] tens = { "","ten","twenty","thirty","forty","fifty", "sixty","seventy","eighty","ninety" };
string[] hundreds = { "thousand", "million", "billion", "trillion", "quadrillion" };

// girdi
Console.WriteLine("x degerini giriniz: ");
string x = Console.ReadLine();
int num = int.Parse(x);
// deger kontrolu
if (num == 0)
{
    Console.WriteLine("Sifir");
    return;
}
// sifirdan kucukse pozitif yap
if (num < 0)
    x = Math.Abs(num).ToString();
// dongu icin uzunluk degeri
int n = x.Length;
int group = (n - 1) / 3;
string text = "";
// islemlerin yapildigi dongu
for (int i = 0; i < n; i++)
{
    int digit = int.Parse(x[i].ToString());
    int place = n - i - 1;
    //sifir degilse
    if (digit != 0)
    {
        // 1 ise
        if (digit == 1 && place % 3 == 2)
            text += "one";
        // 1 degilse
        else
            text += ones[digit];
        // cikti
        text += " " + hundreds[place / 3] + " ";
    }
    if (place % 3 == 1)
        text += tens[digit];
    else if (place % 3 == 2)
        text += ones[digit] + "thousand";
}
// cikti
Console.WriteLine($"Text: {text.Trim()}");