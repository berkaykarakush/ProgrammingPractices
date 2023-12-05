//uretilen rastegele buyuk harfin, en fazla 10 denemede bulunmasi oyunu

Random rnd = new Random();//nesne uretimi
char harf = (char)(rnd.Next(25) + 65); //  65-90 arasi ASCII buyuk harfler, bilincli tur donusumu ile char'a donustur ve ata

//degisken tanimlama ve ilk deger atama
byte hak = 10; //10 deneme 
byte deneme = 1; //deneme sayisini tut
char tahmin; 

while (hak > 0) //0'dan buyukse 
{
    Console.Write("Tahmininizi giriniz: "); //bilgi metni
    tahmin = char.Parse(Console.ReadLine()); //girilen degeri char'a cast et ve ata

    if(tahmin == harf)
    {
        Console.WriteLine($"Tebrikler. {deneme}. tahminde bildiniz.");
        hak = 0; //donguden cik
    }
    else
    {
        deneme++; //her basarisizda bir artir
        Console.WriteLine($"Kalan deneme sayisi: {--hak}"); //her basarisizda degerini bir azalt sonra ekrana yaz
    }
}

if (hak == 0) 
    Console.WriteLine($"Maalesef bilemediniz. Rastgele buyuk harf {harf}'dir.");