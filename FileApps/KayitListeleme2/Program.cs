// Rastgele Erişimli Dosya
// Kullanıcıdan dosya yolunu alır.
Console.Write("Dosya yolunu giriniz: ");
string filePath = Console.ReadLine();
// FileStream sınıfı, dosya üzerinde işlemler yapmak için kullanılır.
// Kullanıcının girdiği dosya yolundaki dosyayı açar ve rastgele erişim sağlar.
FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
// BinaryReader sınıfı, rastgele erişimli dosyadan veri okuma işlemleri için kullanılır.
BinaryReader binaryReader = new BinaryReader(file);
// Dosyadan veri okuma işlemleri gerçekleştirilir.
// Bu örnekte, her bir satırın bir önceki satırdan farklı bir formatta olduğunu varsayıyoruz.
while (binaryReader.PeekChar() != -1)
{
    string line = binaryReader.ReadString();
    Console.WriteLine(line);
}
// BinaryReader ve FileStream kapatılır. Dosyayla ilişkili kaynaklar serbest bırakılır.
binaryReader.Close();
file.Close();
