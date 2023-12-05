//x / y icin x = bolen.y + kalan 'dir 

Console.Write("Pay: "); //bilgi metni 
float pay = float.Parse(Console.ReadLine()); //girilen metni float'a cast et ve ata

Console.Write("Payda: ");
float payda = float.Parse(Console.ReadLine());

float bolen = 0, kalan = pay; //degisken tanimlama ve ilk deger atama 

while(kalan >= payda)
{
    kalan -= payda; //kalan = kalan - payda;
    bolen += 1; //bilen = bolen + 1;
}

Console.WriteLine($"Bolen: {bolen} \nKalan: {kalan}");