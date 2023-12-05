//girilen hipotenus uzungluguna gore tum kenarlar tamsayi ve hipotenusu belirtilen degerden kucuk tum dik ucgenleri bulan program
// a = h , b = h   =>   c  =  (a^2+b^2)^(1/2)  =  (h^2 + h^2)^(1/2)  =  (2*h^2)^(1/2)  =  h*(2^(1/2)) > h  

Console.Write("a^2 + b^2 = c \nHipotenus degerini giriniz: "); //bilgi metni
float hipotenus = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

float c = 0; 
//ic ice dongu kullanilarak 3-4-5 ucgeninden sonra 4-3-5  ucgeninin yazdirilmasi engellenmistir
for (int a = 1; a < hipotenus; a++)
{
    for (int b = a; b < hipotenus; b++) //birinci dongunun o anki degeriyle baslat
    {
        //bilincli tur donusumu
        c = (float)Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));//(a^2+b^2)^(1/2) | Pisagor bagintisi

        if ((c < hipotenus) && (c == Math.Round(c))) //c<h &7 c == Tam(c)
        {
            Console.WriteLine($"a: {a} | b: {b} | c: {c}");
        }
    }
}