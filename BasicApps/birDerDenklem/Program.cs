//birinci derece denklem hesabi 

Console.Write("ax+b=c \na degerini giriniz: "); //bilgi metni
float a = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata

Console.Write("b degerini giriniz: ");
float b = float.Parse(Console.ReadLine());

Console.Write("c degerini giriniz: ");
float c = float.Parse(Console.ReadLine());

Console.WriteLine((c - b) / a);// x = c-b / a