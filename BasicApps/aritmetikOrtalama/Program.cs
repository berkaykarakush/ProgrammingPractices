//girilen uc basamakli pozitif tamsayinin rakamlarinin aritmetik ortalamasini hesaplayan program
int sayi= 0;

while ((sayi < 100) || (sayi > 999)) 
{
    Console.Write("Sayi: ");//bilgi metni
    sayi = int.Parse(Console.ReadLine());//girilen degeri int'a cast et ve ata
}

int bir = sayi % 10; // birler basamagi = sayi mod 10
int on = ((int)(sayi / 10)) % 10 ; //bilincli tur donusumu, onlar basamagi = (sayi/10) mod 10
int yuz = (int)(sayi / 100); //bilincli tur donusumu, yuzler basamagi = sayi / 100
float ortalama = (bir+on+yuz)/3; //ort = basamak toplami / basamak sayisi

Console.WriteLine($"Ortalam => ({yuz}+{on}+{bir})/3 =  {ortalama}");