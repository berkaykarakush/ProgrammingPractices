//Schofield denklemi ile bazal metabolizma hizi 
Console.Write("Kilonuzu giriniz (kg): "); //bilgi metni
float kilo = float.Parse(Console.ReadLine()); //girilen verileri float'a cast et ve ata

Console.Write("Boyunuzu giriniz (cm): ");
float boy = float.Parse(Console.ReadLine());

Console.Write("Yasinizi giriniz: ");
int yas = int.Parse(Console.ReadLine());

Console.Write("Cinsiyetiniz kadin mi ? (true/false): "); //true=kadin | false=erkek
bool cinsiyet = bool.Parse(Console.ReadLine());

float bazalMetabolizmaHizi;
if (cinsiyet == true) //kadin
{
    if (yas < 17 && 10 < yas) //10<yas<17
        bazalMetabolizmaHizi = 692.6f + 13.384f * kilo;
    else if (18 < yas && yas < 29) //18<yas<29
        bazalMetabolizmaHizi = 486.6f + 14.818f * kilo;
    else if (30 < yas && yas < 59)//30<yas<59
        bazalMetabolizmaHizi = 845.6f + 8.126f * kilo;
    else //60<yas
        bazalMetabolizmaHizi = 658.5f + 9.082f * kilo;
}
else //erkek
{
    if (yas < 17 && 10 < yas) //10<yas<17
        bazalMetabolizmaHizi = 658.2f + 17.686f * kilo;
    else if (18 < yas && yas < 29) //18<yas<29
        bazalMetabolizmaHizi = 692.2f + 15.057f * kilo;
    else if (30 < yas && yas < 59)//30<yas<59
        bazalMetabolizmaHizi = 873.1f + 11.472f * kilo;
    else //60<yas
        bazalMetabolizmaHizi = 587.7f + 11.711f * kilo;
}
Console.WriteLine($"Bazal Metabolizma Hizini: {bazalMetabolizmaHizi}");