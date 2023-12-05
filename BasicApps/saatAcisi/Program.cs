//girilen saat ve dakika bilgisine gore akrep ve yelkovanin acisini hesaplama 

Console.Write("Saat (0-11): ");//bilgi metni
int saat = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

Console.Write("Dakika (0-59): ");
int dakika = int.Parse(Console.ReadLine());

int ilerleme = dakika / 2; 
saat *= 30; //saat = 30 * saat , 30'la carpilma sebebi 360/12 = 30
dakika *= 6; //dakika = 6 * dakika , 6'la carpilma sebebi 360/60=6

Console.WriteLine($"Akrep: {saat+ilerleme} \nYelkovan:{dakika}"); //akrep=saat+ilerleme , yelkovan=dakika