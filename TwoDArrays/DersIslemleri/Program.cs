// girdi
Console.Write("Ders sayisini giriniz: ");
// n
int lessonCount = int.Parse(Console.ReadLine());
Console.Write("Ogrenci sayisini giriniz: ");
// m

int studentCount = int.Parse(Console.ReadLine());
// m x n matris tanimlama

int[,] matrix = new int[lessonCount, studentCount];
// toplam degiskeni
int sum = 0;

// degerlerin tutulacagi matris, ortalama, en yuksek note, en dusuk not, en yuksek not no, en dusuk not no
int[,] values = new int[lessonCount, 5];

// ders ortalamaninin tutuldugu degisken
int[] lessonAvgs = new int[lessonCount];

// ogrenci sayisi, satir
for (int i = 0; i < lessonCount; i++)
{
    Console.WriteLine($"{i + 1}. Ders");
    // ders sayisi, sutun
    for (int j = 0; j < studentCount; j++)
	{
		// her bir ogrenci icin not degerlerini al
		Console.Write($"{j+1}. Ogrenci: ");
		matrix[i, j] = int.Parse(Console.ReadLine());

		// her dersin notlar toplami
		sum += matrix[i, j];
    }
	// her dersin sinif ortalamasi values matrisine at
	values[i, 0] = sum / lessonCount;
    sum = 0;
}
// en yuksek ve en dusuk notlarin tutulacagi degiskenler
int hnote = matrix[0, 0], lnote = matrix[0, 0], hnoteStudentNo = 1, lnoteStudentNo = 1;
// ogrenci sayisi, satir
for (int i = 0; i < lessonCount; i++)
{
    // en dusuk notu sifirla
    lnote = matrix[i, 0];
    for (int j = 0; j < studentCount; j++)
    {
        // eger ki en yuksek not yeni degerden kucukse artik en yuksek not o olacaktir
        if (hnote < matrix[i, j])
        {
            hnote = matrix[i, j];
            hnoteStudentNo = j + 1;
        }
        // eger ki en kucuk not yeni degerden buyukse artik en kucuk not o olacaktir
        if (lnote > matrix[i, j])
        {
            lnote = matrix[i, j];
            lnoteStudentNo = j + 1;
        }
    }
    // en yuksek not
    values[i, 1] = hnote;
    // en dusuk not
    values[i, 2] = lnote;
    // en yuksek not yer
    values[i, 3] = hnoteStudentNo;
    // en dusuk not yer
    values[i, 4] = lnoteStudentNo;
}
// cikti
for (int i = 0; i < studentCount; i++)
{
	Console.WriteLine($"\n{i + 1}. Ders");
	Console.WriteLine($"Sinif Ortalamasi: {values[i,0]} \nEn Yuksek Notu: {values[i, 1]} \nEn Dusuk Notu: {values[i, 2]} \nEn Yuksek Notunu Alan Ogrenci No: {values[i, 3]} \nEn Dusuk Notunu Alan Ogrenci No: {values[i, 4]}");
}
