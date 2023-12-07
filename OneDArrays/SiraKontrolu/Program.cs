// degisken tanimlama
int[] numbers = { 1,34,55,66,77,88,4,5 };
Console.WriteLine($"Dizi sirali mi ?: {Sirali(numbers)}");

// Dizinin sirali olup olmadigi cevabin donen method
bool Sirali(int[] numbers)
{
    // kontrol islemi
    for (int i = 1; i < numbers.Length; i++)
    {
        // bi onceki sayi kendinden buyuk ise false
        if (numbers[i] < numbers[i - 1])
            return false;
    }
    return true;
}