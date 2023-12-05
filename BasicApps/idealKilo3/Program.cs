//3. yontemle ideal kilo hesaplayan program
Console.Write("Boyunuzu giriniz(m): "); //bilgi metni
float boy = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata 

Console.Write("Kilonuzu giriniz(kg): ");
float kilo = float.Parse(Console.ReadLine());

Console.Write("Cinsiyetinz kadin mi?(true/false):");
bool cinsiyet = bool.Parse(Console.ReadLine());

//bilincli tur donusumu uygulanmistir
float bedenKutleIndeksi = kilo / (float)(Math.Pow(boy, 2)); //bki = kilo / boy*boy

//ideal kilo 
if (cinsiyet) //true/kadin ise 
{
    Console.WriteLine(@$"Beden kutle indeksi: {bedenKutleIndeksi} 
    Ideal Kilo: {(bedenKutleIndeksi < 17.5 ? "Anoreksi, asiri zayif, yuksek risk" :
    (17.5 < bedenKutleIndeksi && bedenKutleIndeksi < 19.1 ? "Zayif":
    (19.1 < bedenKutleIndeksi && bedenKutleIndeksi < 25.8 ? "Normal kilolu":
    (25.8 < bedenKutleIndeksi && bedenKutleIndeksi < 27.3 ? "Biraz fazla kilolu":
    (27.3 < bedenKutleIndeksi && bedenKutleIndeksi < 32.3 ? "Fazla kilolu":
    (32.3 < bedenKutleIndeksi && bedenKutleIndeksi < 34.9 ? "Cok fazla kilolu":
    (35 < bedenKutleIndeksi && bedenKutleIndeksi < 40 ? "Saglik acisindan yuksek riskli kilolu":
    (40 < bedenKutleIndeksi && bedenKutleIndeksi < 50 ? "Hastalikli bir sekilde asiri kilolu":
    (50 < bedenKutleIndeksi && bedenKutleIndeksi < 60 ? "Super asiri kilolu":"")))))))))}");
}
else//false/erkek icin
{
    Console.WriteLine(@$"Beden kutle indeksi: {bedenKutleIndeksi} 
    Ideal Kilo: {(bedenKutleIndeksi < 17.5 ? "Anoreksi, asiri zayif, yuksek risk" :
    (17.5 < bedenKutleIndeksi && bedenKutleIndeksi < 20.7 ? "Zayif" :
    (20.7 < bedenKutleIndeksi && bedenKutleIndeksi < 26.4 ? "Normal kilolu" :
    (26.4 < bedenKutleIndeksi && bedenKutleIndeksi < 27.8 ? "Biraz fazla kilolu" :
    (27.8 < bedenKutleIndeksi && bedenKutleIndeksi < 31.1 ? "Fazla kilolu" :
    (31.1 < bedenKutleIndeksi && bedenKutleIndeksi < 34.9 ? "Cok fazla kilolu" :
    (35 < bedenKutleIndeksi && bedenKutleIndeksi < 40 ? "Saglik acisindan yuksek riskli kilolu" :
    (40 < bedenKutleIndeksi && bedenKutleIndeksi < 50 ? "Hastalikli bir sekilde asiri kilolu" :
    (50 < bedenKutleIndeksi && bedenKutleIndeksi < 60 ? "Super asiri kilolu":"")))))))))}");
}