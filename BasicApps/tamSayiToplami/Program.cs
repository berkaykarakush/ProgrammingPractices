//n sayisina gore 1'den n'e kadar tamsayilarin toplami, 1'den n'e kadar tek tamsayilarin toplami, 2'den n'e kadar cift tamsayilarin toplami

Console.Write("n sayisini giriniz: "); //bilgi metni
int n = int.Parse(Console.ReadLine()); //girilen degeri int'a cast et ve ata

int tamsayiToplami = 0, tekSayiToplami = 0, ciftSayiToplami=0; //ilk deger atamasi

for(int i = 0; i < n; i++) 
{

    tamsayiToplami += i; //tamsayiToplami = tamsayiToplam + i
    int deger = i % 2 == 0 ? ciftSayiToplami += i : tekSayiToplami += i; //ture ise ciftSayiToplami = ciftSayiToplami + i, false ise tekSayiToplami=tekSayiToplami+i
}
Console.WriteLine($"Tum sayilarin toplami: {tamsayiToplami} \nTek sayilarin toplami: {tekSayiToplami} \nCift sayilarin toplami: {ciftSayiToplami}");//cikti