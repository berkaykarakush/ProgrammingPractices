//n elemanli dizinin standart sapmasini ve varyansini hesaplama
#region Degisken tanimlama ve ilk deger atama
int elemanSayisi = 0;
float aritmetikOrt = 0f;
float toplam = 0f;
float standartSapma = 0f;
float varyans = 0f;
#endregion
Console.Write("Dizinin eleman sayisini giriniz: ");//eleman sayisini al
elemanSayisi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

float[] dizi = new float[elemanSayisi];//girilen eleman sayisi kadarlik float dizisi tanimla
for (int i = 0; i < elemanSayisi; i++)
{
    Console.Write($"{(i + 1)}'nci eleman: ");
    dizi[i] = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata
    aritmetikOrt += dizi[i];//aritmetik ortalama = aritmetik ortalama + dizi[i] ,her girilen deger ile eleman toplamini topla
}

aritmetikOrt /= elemanSayisi;//aritmetik ortalama = elemanlar toplami / eleman sayisi 

for (int i = 0; i < elemanSayisi; i++)
{
    toplam += (float)(Math.Pow((dizi[i] - aritmetikOrt), 2)); //toplam = toplam +(dizi[i] - aritmetik ortalama) ^ 2
}

varyans = toplam / elemanSayisi;
standartSapma = (float)(Math.Sqrt(varyans));//varyans'in karekoku standart sapma degerini verir

Console.WriteLine($"Dizinin \n-Standart Sapmasi: {standartSapma,0:F3} \n-Varyansi: {varyans,0:F3}");