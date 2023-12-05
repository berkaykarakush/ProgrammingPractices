//pozitif bir tamsayinin, iki sayinin kareleri toplami seklinde yazilip yazilamaycagini hesaplayan program
Console.Write("i^2 + j^2 = sayi \nSayiyi giriniz: "); //bilgi metni
int sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata

//i ve j'nin alabilecegi en buyuk deger Sqrt(sayi) olabileceginden dolayi donguler Sqrt(sayi) 'ya kadar ayarlanmis ve gereksiz tekrardan kacinilmistir
for (int i = 0; i < Math.Sqrt(sayi); i++)
{
    for (int j = 0; j < Math.Sqrt(sayi); j++)
    {
        if(Math.Pow(i,2) + Math.Pow(j,2) == sayi)
        {
            Console.WriteLine($"i:  {i} | j:  {j}");
        }
    }
}