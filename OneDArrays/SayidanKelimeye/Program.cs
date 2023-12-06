// sayilarin isim karsiliklarinin tutuldugu dizi
string[] numbers = new string[10];
numbers[0] = "zero";
numbers[1] = "one";
numbers[2] = "two";
numbers[3] = "three";
numbers[4] = "four";
numbers[5] = "five";
numbers[6] = "six";
numbers[7] = "seven";
numbers[8] = "eight";
numbers[9] = "nine";
// sayi girdisi
Console.Write("enter the number -9 to 9: ");
int number = int.Parse(Console.ReadLine());
// pozitif cikti
if (number > 0)
    Console.WriteLine($"{numbers[Math.Abs(number)]}");
// sifir ise
else if(number == 0)
    Console.WriteLine($"{numbers[Math.Abs(number)]}");
// negatif cikti
else
    Console.WriteLine($"minus {numbers[Math.Abs(number)]}");