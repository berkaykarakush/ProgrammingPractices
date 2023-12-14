// Sıralı Erişimli Dosya
// FileStream sınıfı, dosya üzerinde işlemler yapmak için kullanılır.
// "guide.txt" adlı dosyayı açar ve sadece okuma yetkisi verir.
FileStream file = new FileStream("guide.txt", FileMode.Open, FileAccess.Read);
// StreamReader sınıfı, metin okuma işlemleri için kullanılır ve FileStream'e bağlanır.
StreamReader streamReader = new StreamReader(file);
// Dosyadan bir satır okunur.
string line = streamReader.ReadLine();
// Dosya sonuna kadar satırları okuyarak ekrana yazdırır.
while (line != null)
{
    Console.WriteLine(line);
    // Bir sonraki satıra geçer.
    line = streamReader.ReadLine();
}
// StreamReader ve FileStream kapatılır. Dosyayla ilişkili kaynaklar serbest bırakılır.
file.Close();
