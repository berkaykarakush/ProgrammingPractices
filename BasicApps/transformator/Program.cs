//Ideal transformatorin primer (giris) tarafina ait gerilim, akim ve sayim sayisiyla sekonder (cikis) tarafina ait sarim sayisi klavyeden girilmektedir. Buna gore
//transformatorun sekonder tarafina it gerilim, akim ve guc degerlerini hesaplayip turunu tespit ederek sonuclari yazdiran program

Console.Write("Vp degerini giriniz: "); //bilgi metni
float VP = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata

Console.Write("Ip degerini giriniz: ");
float IP = float.Parse(Console.ReadLine());

Console.Write("Np degerini giriniz: ");
float NP = float.Parse(Console.ReadLine());

Console.Write("Ns degerini giriniz: ");
float NS = float.Parse(Console.ReadLine());

float VS = VP * NS / NP;//vs=vp*ns/np
float IS = IP * NP / NS;//is = ip*np/ns
float PS = VS * IS;//ps = vs*is

Console.WriteLine($"VS degeri: {VS} \nIs degeri: {IS} \nPs degeri: {PS}"); 

Console.WriteLine(VS > PS ? "Yukseltici" : "Dusurucu"); //vs buyukse yukseltici, vs kucukse dusurucu yaz