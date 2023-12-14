// FileStream sınıfı, dosya üzerinde işlemler yapmak için kullanılır.
// "guide.txt" adlı dosyayı açar veya oluşturur. Yazma yetkisi verilmiştir.
FileStream file = new FileStream("guide.txt", FileMode.OpenOrCreate, FileAccess.Write);
// StreamWriter sınıfı, metin yazmak için kullanılır ve FileStream'e bağlanır.
StreamWriter writer = new StreamWriter(file);
// Kullanıcıdan Ad Soyad bilgisini alır.
Console.Write("Ad Soyad: ");
string nameSurname = Console.ReadLine();
// Kullanıcıdan Telefon bilgisini alır.
Console.Write("Telefon: ");
string phoneNumber = Console.ReadLine();
// Kullanıcıdan Adres bilgisini alır.
Console.Write("Adres: ");
string address = Console.ReadLine();
// Kullanıcının girdiği bilgileri dosyaya yazma işlemi gerçekleştirilir.
writer.WriteLine(nameSurname + " " + phoneNumber + " " + address);
// Verilerin dosyaya yazılmasını garanti altına almak için StreamWriter'ın buffer'ını boşaltır.
writer.Flush();
// StreamWriter'ı ve FileStream'ı kapatır. Dosyayla ilişkili kaynakları serbest bırakır.
writer.Close();
// Kullanıcıya bir satır boşluk bırakarak işlemin tamamlandığı bilgisi verilir.
Console.WriteLine("Dosya yazma işlemi tamamlandı.");
