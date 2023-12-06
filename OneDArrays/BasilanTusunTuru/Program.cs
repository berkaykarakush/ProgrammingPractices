using System.Text;
// girdi
Console.Write("input: ");
string input = Console.ReadLine();
// alinan degeri ascii koduna donusturen method
var bytes = ASCIIEncoding.ASCII.GetBytes(input);
// cikti
foreach (var b in bytes)
    Console.WriteLine(b);