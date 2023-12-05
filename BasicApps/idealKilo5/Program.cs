//5. yontemle ideal kilo hesaplayan program
Console.Write("Boyunuzu giriniz(m): "); //bilgi metni
float boy = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata 

Console.Write("Kilonuzu giriniz(kg): ");
float kilo = float.Parse(Console.ReadLine());

Console.Write("Cinsiyetinz kadin mi?(true/false):");
bool cinsiyet = bool.Parse(Console.ReadLine());

//yagsiz beden agirligi
Console.WriteLine(cinsiyet == true ? $"Yagsiz beden agirligi: {(1.07 * kilo - 148 * Math.Pow(kilo, 2) / (Math.Pow(100 * boy, 2)))}" :
                                        $"Yagsiz beden agirligi: {(1.1 * kilo - 128 * Math.Pow(kilo, 2) / (Math.Pow(100 * boy, 2)))}");