//girilen n adet pozitif tamsayinin sadece birler basamaklarini toplayan program
Console.Write("Kac adet sayi gireceksiniz: "); //bilgi metni
int n = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata
int toplam = 0; //degerleri toplamak icin kullanilacak
for (int i = 0; i < n; i++)
{
    Console.Write("Sayi degerini giriniz:");
    int sayi = int.Parse(Console.ReadLine());

    toplam += sayi % 10; //birler basamagini al, toplam = toplam + sayi % 10
}
Console.Write($"Toplam = {toplam}");