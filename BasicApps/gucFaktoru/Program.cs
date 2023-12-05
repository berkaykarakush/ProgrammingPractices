 //Bir guc sistemine ait gerilim ve akimin Volt ile Amper cinsinden genlikleri ve derece cinsinden de faz acilari girilmektedir. Buna gore sistemdeki
//akitf-reaktif-gorunur gucu ve guc faktorunu hesaplayip ekrana yazdiran program

Console.Write("Volt degerini giriniz: "); //bilgi metni
float volt = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Amper degerini giriniz: ");
float amper = float.Parse(Console.ReadLine());

Console.Write("Faz Acisi degerini giriniz: ");
float fazAcisi = float.Parse(Console.ReadLine());

fazAcisi = (float)(fazAcisi * Math.PI / 180); //fi=fi*pi/180 , ayrica bilincli tur donumusu uyguladim cunku Math class'indan double deger donmekte
float gorunurGuc = volt * amper; //v=s*i
float gucFaktoru = (float)Math.Cos(fazAcisi); //gf=cos(fi)
float aktifGuc = gorunurGuc * gucFaktoru; //p=s*gf
float reaktifGuc = gorunurGuc * (float)Math.Cos(fazAcisi); //q=s*sin(fi)

Console.WriteLine($"Aktif Guc: {aktifGuc} \nReaktif Guc: {reaktifGuc} \nGorunur Guc: {gorunurGuc} \nGuc Faktoru: {gucFaktoru}");