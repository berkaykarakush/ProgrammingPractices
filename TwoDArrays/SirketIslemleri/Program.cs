// girdi
Console.Write("Sirket sayisini giriniz: ");
int companyCount = int.Parse(Console.ReadLine());
// n x 12 lik matris
int[,] matrix = new int[companyCount, 12];
// satir, sirket sayisi
for (int i = 0; i < companyCount; i++)
{
    // sutun, aylar
    Console.WriteLine($"{i+1}.Sirket\n******************\n");
    for (int j = 0; j < 12; j++)
    {
        Console.WriteLine($"{j + 1}.Ay Kar Orani: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}
// bosluk
Console.WriteLine("--------------------------------------");
// satir, sirket sayisi
for (int i = 0; i < companyCount; i++)
{
    // her sirket icin toplam degiskenini sifirla
    int sum = 0;
    // sutun, aylar
    for (int j = 0; j < 12; j++)
    {
        // sirketin yillik toplam kari
        sum += matrix[i, j];
    }
    // her sirketin karini hesapla
    int profit = sum / 12;
    Console.WriteLine($"{i+1}.Sirketin Yillik Kari: {profit}");
}
// bosluk
Console.WriteLine("--------------------------------------");
// satir, sirketler
for (int i = 0; i < companyCount; i++)
{
    // gerekli degiskenler
    int lowProfit = matrix[i, 0], highProfit = matrix[i, 0], lowProfitM = 1, highProfitM = 1;
    // sutun, aylar
    for (int j = 0; j < 12; j++)
    {
        // en kucuk degerden kucukse yeni olarak guncelle
        if (matrix[i,j] < lowProfit)
        {
            // en az kar degeri
            lowProfit = matrix[i, j];
            // ay degeri
            lowProfitM = j;
        }
        // en buyuk degerden buyukse yeni olarak guncelle
        if (matrix[i,j] > highProfit)
        {
            // en fazla kar degeri
            highProfit = matrix[i, j];
            // ay degeri
            highProfitM = j;
        }
    }
    // cikti
    Console.WriteLine($"{i+1}. Sirket icin \nEn Az Kar: {lowProfit} \nEn Karin Oldugu Ay: {lowProfitM} \nEn Yuksek Kar: {highProfit} \nEn Yuksek Karin Oldugu Ay: {highProfitM}");
}
// bosluk
Console.WriteLine("--------------------------------------");
// satir, aylar
for (int i = 0; i < 12; i++)
{
    // gerekli degiskenler
    int low = matrix[0, i], high = matrix[0, i], lows = 1, highs = 1;
    // sutun, sirketler
    for (int j = 0; j < companyCount; j++)
    {
        // en az deger yeni gelenden buyukse en az degeri guncelle
        if (matrix[j,i] < low)
        {
            // en az deger 
            low = matrix[j, i];
            // sirket degeri
            lows = j;
        }
        // en yuksek deger yeni gelenden kucukse en yuksek degeri guncelle
        if (matrix[j,i] > high)
        {
            // en yuksek deger
            high = matrix[j, i];
            // sirket degeri
            highs = j;
        }
    }
    // cikti
    Console.WriteLine($"{i+1}. Ay icin \nEn Yuksek Kar: {high} \nEn Yuksek Kar Sirketi: {highs} \nEn Dusuk Kar: {low} \nEn Dusuk Kar Sirketi: {lows}");
}