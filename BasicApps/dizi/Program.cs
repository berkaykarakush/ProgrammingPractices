 //girilen N adet verinin A dizisine atanmasi 
Console.Write("Kac adet sayi gireceginizi belirtiniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata
int[] sayilar = new int[sayi];//sayi degiskeninin degeri kadar elemaani olan dizi olustur

for (int i = 0; i<sayi;i++)
{
    sayilar[i] = i; //donguden gelen degeri diziye ekle
    Console.WriteLine($"Dizinin {i+1}. Elemani: {i}"); //1. degerden baslayarak yaz, i degerini dondur

}