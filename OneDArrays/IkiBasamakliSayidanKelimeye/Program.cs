// sayilarin karsiliklari
string[] tens = new string[9];
tens[0] = "ten";
tens[1] = "twenty";
tens[2] = "thirty";
tens[3] = "forty";
tens[4] = "fifty";
tens[5] = "sixty";
tens[6] = "seventy";
tens[7] = "egithty";
tens[8] = "ninety";
string[] ones= new string[10];
ones[0] = "zero";
ones[1] = "one";
ones[2] = "two";
ones[3] = "three";
ones[4] = "four";
ones[5] = "five";
ones[6] = "six";
ones[7] = "seven";
ones[8] = "eight";
ones[9] = "nine";
// girdi
Console.Write("enter the number: ");
int number = int.Parse(Console.ReadLine());
// sifirsa
if (number == 0)
{
    Console.WriteLine("zero");
    return;
}
// onlar basamagi
int y = number / 10;
// birler basamagi
int z = number % 10;
// cikti
Console.WriteLine($"Tens: {tens[y-1]} | Ones: {ones[z]}");