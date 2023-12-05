//Dunya Saglik Orgutu Hesaplama Formulu ile bazal metabolizma hizi 
Console.Write("Kilonuzu giriniz (kg): "); //bilgi metni
float kilo = float.Parse(Console.ReadLine()); //girilen verileri float'a cast et ve ata

Console.Write("Boyunuzu giriniz (cm): ");
float boy = float.Parse(Console.ReadLine());

Console.Write("Yasinizi giriniz: ");
int yas = int.Parse(Console.ReadLine());

Console.Write("Cinsiyetiniz kadin mi ? (true/false): "); //true=kadin | false=erkek
bool cinsiyet = bool.Parse(Console.ReadLine());

float bazalMetabolizmaHizi = 0; //degisken tanimlama ve ilk deger atama 

if (cinsiyet == true) //kadin
{
    if (yas > 18 && yas < 30) //18<yas<30
        bazalMetabolizmaHizi = 496f + 14.7f * kilo;
    else if (yas > 31 && yas < 60) //31<yas<60
        bazalMetabolizmaHizi = 829f + 8.7f * kilo;
    else if (yas > 61)//yas > 61
        bazalMetabolizmaHizi = 845.6f + 8.126f * kilo;
}
else //erkek
{
    if (yas > 18 && yas < 30) //18<yas<30
        bazalMetabolizmaHizi = 679f + 15.3f * kilo;
    else if (yas > 31 && yas < 60) //31<yas<60
        bazalMetabolizmaHizi = 879f + 11.6f * kilo;
    else if (yas > 61)//yas > 61
        bazalMetabolizmaHizi = 487f + 13.5f * kilo;
}

Console.WriteLine($"Bazal Metabolizma Hizini: {bazalMetabolizmaHizi}");