 //basamaklarinin toplami basamak sayisina esit olan 100-999 arasindaki tamsayilari bulan program
Console.WriteLine("basamaklarinin toplami basamak sayisina esit olan 100-999 arasindaki tamsayilari bulan program\n");//bilgi metni
for (int i = 1; i < 9; i++) //100'ler basamagi
{
    for (int j = 0; j < 9; j++) //10'lar basamagi
    {
        for (int k = 0; k < 9; k++) //1'ler basamagi 
        {
            if (i+j+k == 3) //basamak toplami 3 olma durumu cunku btoplami == bsayisi
            {
                Console.WriteLine($"{100*i} + {10*j} + {k} = {100*i+10*j+k}");
            }
        }
    }
}