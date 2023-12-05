//Maclaurin serisi kullanarak cos(x) hesaplama 

Console.Write("aci degerini giriniz: "); //bilgi metni
float aci = float.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("Terim sayisini giriniz: ");
int terimSayisi = int.Parse(Console.ReadLine());

float x = (float)(Math.PI * aci / 180); //bilincli tur donusumu, x = pi*aci/180
//float f;
int s = 1;
float t = 1;

for (int i = 1; i <= terimSayisi - 1; i++) //Maclaurin serisi terim sayisi kadar ac
{
    float f = 1; //carpmada kullanilacagi icin 1 baslangic degeri 

    for (int j = 1; j <= 2*i; j++)
        f *= j; //f = f * j

    s *= (-1); // s = s -1 yani -s 
    t += s * (float)(Math.Pow(x, 2 * i)) / f ; // t = t + s * x^(2*i) / f, bilincli tur donusumu uygulanmistir
}

Console.WriteLine($"Sonuc: {t}");