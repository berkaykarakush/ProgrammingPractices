//viete formulleri 
Console.WriteLine("a2x^2 +  a1x + a0 polinomunda");//bilgi metni

Console.Write("x1 degerini giriniz: "); //x1 = a2x^2 olan
float x1 = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("x2 degerini girini: "); //x2= a1x olan
float x2 = float.Parse(Console.ReadLine());

float ktop = x1 + x2; //toplamlari
float kcarp = x1 * x2;  //carpimlari

Console.Write(ktop < 0 ? $"x^2+{-1*ktop}x" : $"x^2-{ktop}x"); //ktop kucukse "": tetiklenir , ktop kucuk degilse :"" tetiklenir
Console.Write(kcarp< 0 ? $"{kcarp}" : $"+{kcarp}"); //kcar kucukse "": tetiklenir, kcarp kucuk degilse :"" tetiklenir
//x^2+4x+5 seklinde cikti olusur