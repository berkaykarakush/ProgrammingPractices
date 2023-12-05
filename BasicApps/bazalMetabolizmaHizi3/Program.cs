//Owen denklemi ile bazal metabolizma hizi 
Console.Write("Kilonuzu giriniz (kg): "); //bilgi metni
float kilo = float.Parse(Console.ReadLine()); //girilen verileri float'a cast et ve ata

Console.Write("Cinsiyetiniz kadin mi ? (true/false): "); //true=kadin | false=erkek
bool cinsiyet = bool.Parse(Console.ReadLine());

Console.WriteLine(cinsiyet == true ? $"Bazal Metabolizma Hizini: {(795f + 7.18f * kilo)}":  //kadin
                                        $"Bazal Metabolizma Hizini: {(879f + 10.2f * kilo)}"); //erkek