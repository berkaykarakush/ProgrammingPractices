//4. yontemle ideal kilo hesaplayan program
Console.Write("Boyunuzu giriniz(m): "); //bilgi metni
float boy = float.Parse(Console.ReadLine()); //girilen degeri float'a cast et ve ata 

Console.Write("Kilonuzu giriniz(kg): ");
float kilo = float.Parse(Console.ReadLine());



//bilincli tur donusumu uygulanmistir
float bedenKutleIndeksi = kilo / (float)(Math.Pow(boy, 2)); //bki = kilo / boy*boy

//ideal kilo 

Console.WriteLine(@$"Beden kutle indeksi: {bedenKutleIndeksi} 
    Ideal Kilo: {(bedenKutleIndeksi < 18.5 ? "Zayif" : //18.5 < bki
    (18.5 < bedenKutleIndeksi && bedenKutleIndeksi < 24.9 ? "Normal" : //18.5 < bki < 24.9
    (25 < bedenKutleIndeksi && bedenKutleIndeksi < 29.9 ? "Fazla kilolu" : //25 < bki < 29.9
    (30 < bedenKutleIndeksi && bedenKutleIndeksi < 34.9 ? "I.derece obez" : //30 < bki < 24.9
    (35 < bedenKutleIndeksi && bedenKutleIndeksi < 39.9 ? "II.derece obez" : //35 < bki < 39.9
    (40 < bedenKutleIndeksi ? "III. derece obez" :""))))))}"); //40< bki