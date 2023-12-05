//iki tamsayinin carpimi birisinin kendisiyle diigeri kadar toplamidir

Console.Write("1.Sayiyi giriniz: ");//bilgi metni
int birinciSayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

Console.Write("2.Sayiyi giriniz: ");
int ikinciSayi = int.Parse(Console.ReadLine());

int carpim = 0; //degisken tanimlama ve ilk deger atama
for(int i = 1; i <= ikinciSayi; i++) //1'den basla sayi dahil
{
    carpim += birinciSayi;//toplam = toplam + birinciSayi
}
Console.WriteLine($"{birinciSayi} x {ikinciSayi} = {carpim}");