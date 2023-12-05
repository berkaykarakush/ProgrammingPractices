//Ilk n basamagindaki rakamlarin toplami, son n basamagindaki rakamlarin toplamina esit olan 2n basamakli tamsayilar elde edilmeye calisilmaktadir.
//Bu ozellige sahip 1000-9999 arasindaki tamsayilarin listesini veren program

for (int i = 1; i <= 9; i++)//1000'ler basamagi
{
    for (int j = 0; j <= 9; j++)//100'ler basamagi
    {
        for (int k = 0; k <= 9; k++) //10'lar basamagi
        {
            for (int m = 0; m <= 9; m++)//1'ler basamagi
            {
                if (i + j == k + m) //1230 icin 1+2 = 3+0 sarti  
                {
                    Console.WriteLine($"{1000 * i} + {100 * j} + {10 * k} + {m} = {1000 * i + 100 * j + 10 * k + m}");
                }
            }
        }
    }
}