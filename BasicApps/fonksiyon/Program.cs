//bir y=f(x) icin x ve y hesaplama
//f(x) = 1, x<0 | x, 0<=x<=2 | 3, 2<x<4 | 4-x, 4<x

Console.Write("x degerini gir: "); //bilgi metni
float x = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata
float y=0;//ilk deger atama

Console.WriteLine(x < 0 ? $"y = {y=1}" ://x<0
                    (0 <= x && x <= 2)? $"y = {y=x}" ://0<=x<=2
                    (x>2 && x<4) ? $"y = {y=3}"//2<x<4
                    : $"y = {y=4-x}");//4-x 