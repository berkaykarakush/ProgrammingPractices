// sayilarin karsiliklarini tutan dizi
string[] numbers = new string[10];
numbers[0] = "one";
numbers[1] = "two";
numbers[2] = "three";
numbers[3] = "four";
numbers[4] = "five";
numbers[5] = "six";
numbers[6] = "seven";
numbers[7] = "eight";
numbers[8] = "nine";
// girdi
Console.Write("enter the number 0-9: ");
int number = int.Parse(Console.ReadLine());
// 1'den girdiye kadar sirasiyla sayilari listeler
for (int i = 0; i < number; i++)
{
    Console.WriteLine(numbers[i]);
}