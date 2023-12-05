//ln(2) = 1/2 + 1/12 + 1/30 + 1/56 + 1/90 + .. seklinde hesaplanabilmektedir. Paylar surekli 1 paydalar da ardisik sayilarin carpimidir. Yani 2=1*2 , 12=3*4, 30=5*6..

Console.Write("ln(n) icin \nn degerini giriniz: "); //bilgi metni
int n = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

float toplam = 0;//degisken tanimalama ve ilk deger atama
for (int k = 0; k < n; k++) // k <= n-1
{
    // 1 / (k+1)*(k+2)
    toplam += 1/((2 * k + 1) * (2 * k + 2)); //t = t + 1/((2*k+1)*(2*k+2))
}

Console.WriteLine($"ln{n} = {toplam}");