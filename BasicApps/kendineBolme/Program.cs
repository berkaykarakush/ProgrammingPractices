//kendi hanelerine tam bolunen 11-99 arasi tamsayilari listeleyen program

int tamsayi = 1;//degisken tanimlama ve ilk deger atama 
for (int i = 1; i < 9; i++) //1'den 9'a 
{
    for (int j = 1; j < 9; j++) //1'den 9'a
    {
        tamsayi = 10 * i + j;//90 + 9 == 99'a 
        if ((tamsayi % i == 0 ) && (tamsayi % j == 0)) //tamsayi % i =0 VE tamsayi % j = 0
        {
            Console.WriteLine($"Tamsayi: {tamsayi}");
        }
    }
}