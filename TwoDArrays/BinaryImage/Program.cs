// Matris boyutlarını tanımla
int m = 9;
int n = 4;
// Boolean tipinde bir matris oluştur
bool[,] matrix = new bool[9, 4];
// Belirli konumlara true değerleri ata
matrix[2, 2] = true;
matrix[2, 3] = true;
matrix[3, 2] = true;
matrix[3, 3] = true;
matrix[6, 2] = true;
matrix[6, 3] = true;
matrix[7, 2] = true;
matrix[7, 3] = true;
matrix[8, 2] = true;
matrix[8, 3] = true;
// Satır sayısı kadar döngü
for (int i = 0; i < m; i++)
    // Sütun sayısı kadar döngü
    for (int j = 0; j < n; j++)
        // siyahi beyaz yap, beyazi siyah yap
        matrix[i, j] = !matrix[i, j];
