//Maclaurin serisi kullanarak sinx(x) hesaplama 

Console.Write("aci degerini giriniz: "); //bilgi metni
float aci = float.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("Terim sayisini giriniz: ");
int terimSayisi = int.Parse(Console.ReadLine());

float x = (float)(Math.PI * aci / 180); //bilincli tur donusumu, x = pi*aci/180
//float f;
int s = 1;
float t = 0;

for (int i = 1; i < terimSayisi; i++) //Maclaurin serisi terim sayisi kadar ac
{
    float f = 1; //carpmada kullanilacagi icin 1 baslangic degeri 

    for (int j = 1; j <= 2 * i - 1; j++)
        f *= j; //f = f * j

    s *= (-1); // s = s -1 yani -s 
    t += (float)(Math.Pow(s, i - 1) * Math.Pow(x, 2 * i - 1)) / f; //t = t + ((-1)^(i-1)*(x^(2*i-1))/f
}

Console.WriteLine($"Sonuc: {t}");