//n. dereceden y(x) = anxn + an-1xn-1 + ... + a0 polinomunun x = b icin degerini (y(b)) hesaplayan program
#region Degisken tanimlama  ve ilk deger atama
int derece = 0;
int xDegeri = 0;
float toplam = 0f;
#endregion


Console.Write("y(x) polinomunun derecesi: ");//deger iste
derece = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

float[] dizi = new float[derece+1]; //girilen derece + 1 kadarlik float dizisi tanimla   

for (int i = 0; i <= derece; i++)
{
    Console.Write($"x^{i} katsayisi: ");
    dizi[i] = float.Parse(Console.ReadLine()); 
}

Console.Write("Hesaplanacak x degerini giriniz: ");
xDegeri = int.Parse(Console.ReadLine());

toplam = dizi[0];

for (int i = 1; i <= derece; i++)
    toplam += dizi[i] * (float)(Math.Pow(xDegeri, i)); //toplam = toplam + dizi[i] * b^i

Console.WriteLine($"y({xDegeri,0:F3}) = {toplam,0:F3}");