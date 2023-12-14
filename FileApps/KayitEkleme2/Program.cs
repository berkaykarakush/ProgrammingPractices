Console.Write("Dosya adi: ");
string fileName = Console.ReadLine() + ".txt";
Console.Write("Ad: ");
string name = Console.ReadLine();
Console.Write("Telefon: ");
string phone = Console.ReadLine();
Console.Write("Adres: ");
string address = Console.ReadLine();

// Dosya adına ".txt" uzantısını ekleyerek FileStream oluştur
using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
{
    // StreamWriter kullanarak dosyaya yazma işlemi
    using (StreamWriter streamWriter = new StreamWriter(fileStream))
    {
        // Kullanıcıdan alınan bilgileri dosyaya yaz
        streamWriter.WriteLine($"{name} - {phone} - {address}");
        Console.WriteLine($"Islem tamamlandi {fileStream.Name}");
    }
}
