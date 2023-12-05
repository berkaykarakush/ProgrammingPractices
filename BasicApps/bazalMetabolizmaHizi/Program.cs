//Harris-Benecdict denklemi ile bazal metabolizma hizi 
Console.Write("Kilonuzu giriniz (kg): "); //bilgi metni
float kilo = float.Parse(Console.ReadLine()); //girilen verileri float'a cast et ve ata

Console.Write("Boyunuzu giriniz (cm): ");
float boy= float.Parse(Console.ReadLine());

Console.Write("Yasinizi giriniz: ");
int yas = int.Parse(Console.ReadLine());

Console.Write("Cinsiyetiniz kadin mi ? (true/false): "); //true=kadin | false=erkek
bool cinsiyet = bool.Parse(Console.ReadLine());

Console.WriteLine(cinsiyet == true ? $"Bazal Metabolizma Hizi: {(655.0955 + 9.5634 * kilo + 1.8496 * boy - 4.6756 * yas)}" : //kadin icin  
                                        $"Bazal Metabolizma Hizi: {(66.473 + 13.7516 * kilo + 5.0033 * boy - 6.775 * yas)}"); //erkek icin