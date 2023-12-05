//signum(isaret) fonksiyonu
//sgn(f(x)) = -1, f(x)<0 | 0, f(x)=0 | 1, f(x) > 0

Console.Write("x degerini giriniz: "); //bilgi metni
float x = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata
//bilincli tur donusumu
float fx = (float)Math.Pow(x, 2) - 5 * x + 3; //fx = x^2 - 5x + 3
Console.WriteLine(fx<0 ? "sonuc: -1" : //f(x)<0
                    (fx == 0 ? "sonuc: 0" //f(x) = 0
                    :"1")); //f(x) > 0