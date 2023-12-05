//Dunya Saglik Orgutu Pratik Hesaplama Formulu ile bazal metabolizma hizi 
Console.Write("Kilonuzu giriniz (kg): "); //bilgi metni
float kilo = float.Parse(Console.ReadLine()); //girilen verileri float'a cast et ve ata

Console.Write("Cinsiyetiniz kadin mi ? (true/false): "); //true=kadin | false=erkek
bool cinsiyet = bool.Parse(Console.ReadLine());

Console.WriteLine(cinsiyet == true ? $"Bazal Metabolizma Hizini: {(22.8f * kilo)}" :  //kadin
                                        $"Bazal Metabolizma Hizini: {(24f * kilo)}"); //erkek