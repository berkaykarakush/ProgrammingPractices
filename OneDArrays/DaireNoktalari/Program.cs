// degerlerin alinmasi
Console.Write("(x -a )^2 + (y - b)^2 = r^2 \na degeri:");
double a = double.Parse(Console.ReadLine());
Console.Write("b degeri: ");
double b = double.Parse(Console.ReadLine());
Console.Write("r degeri: ");
double r = double.Parse(Console.ReadLine());
Console.Write("x ve Y dizilerinin eleman sayisi: ");
int n = int.Parse(Console.ReadLine());
// dizi degerlerinin alinmasi
double[] arrayX = new double[n];
double[] arrayY = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"x dizisinin {i+1}.Elemani: ");
    arrayX[i] = double.Parse(Console.ReadLine());
    Console.Write($"y dizisinin {i + 1}.Elemani: ");
    arrayY[i] = double.Parse(Console.ReadLine());
}
double isay = 0, dsay = 0, usay = 0;
// islemlerin yapildigi dongu
for (int i = 0; i < n; i++)
{
    double f = (arrayX[i] - a) * (arrayX[i] - a) + (arrayY[i] - b) * (arrayY[i] - b);
    // daireninin icinde
    if (f < r * r)
        isay++;
    // daireinin disinde
    if (f > r * r)
        dsay++;
    //esite uzerinde
    else
        usay++;
}
// cikti
Console.WriteLine($"Iceride: {isay} \nDisarida: {dsay} \nUzerinde:{usay}");


