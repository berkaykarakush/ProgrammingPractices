//Mifflin-St Jeor denklemi ile bazal metabolizma hizi 
Console.Write("Kilonuzu giriniz (kg): "); //bilgi metni
float kilo = float.Parse(Console.ReadLine()); //girilen verileri float'a cast et ve ata

Console.Write("Boyunuzu giriniz (cm): ");
float boy = float.Parse(Console.ReadLine());

Console.Write("Yasinizi giriniz: ");
int yas = int.Parse(Console.ReadLine());

Console.Write("Cinsiyetiniz kadin mi ? (true/false): "); //true=kadin | false=erkek
bool cinsiyet = bool.Parse(Console.ReadLine());

Console.WriteLine(cinsiyet == true ? $"Bazal Metabolizma Hizini: {(9.99f * kilo + 6.25f * boy - 4.92f * yas -161)}": //kadin 
                                        $"Bazal Metabolizma Hizini: {(9.99f * kilo + 6.25f * boy - 4.92f * yas + 5)}"); //erkek