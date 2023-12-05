//Devreye ait gerilim kaynagi ve direnc degerleri klavyeden girilmektedir. Buna gore devreden akan akimi(I), R1 direnci uzerindeki gerilim dusumunu ve R2 direncinde harcanan gucu hesaplayip ekrana yazdiran program
Console.Write("Gerilim degerini giriniz (E): ");//bilgi metni
float E = float.Parse(Console.ReadLine());//girilen degeri float'a cast et ve ata
float[] R = new float[4];//4luk dizi olustur

for (int i = 0; i < 4; i++)//r1-r2-r3-r4 degerlerini icin dongu
{
    Console.Write($"R{i+1} degerini giriniz: ");//r1 r2 seklinde yaz
    R[i] = float.Parse(Console.ReadLine());//girilen degerleri tek tek dizi elemanlarina ata
}

float I = E / (R[0] + R[1] + R[2] + R[3]); //I=E/(R1+R2+R3+R4)
float VR1 = R[0] * I; //VR1=R1*I
float PR2 = ((float)Math.Pow(I, 2)) * R[1];//PR2= I^2*R1, (float) ile Pow'dan donecek olan double degeri bilincli tur donusumune tabi tuttum

Console.WriteLine($"I: {I} \nVR1: {VR1} \nPR2: {PR2}");