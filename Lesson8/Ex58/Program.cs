// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] array1 = CreatureRndArray(3, 3, 0, 5);
Console.WriteLine("Исходный массив 1");
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreatureRndArray(3, 2, 0, 5);
Console.WriteLine("Исходный массив 2");
PrintMatrix(array2);
Console.WriteLine();

// int[,] array1 = new int[2, 2] { { 2, 4 }, { 3, 2 } }; // проверка решения
// int[,] array2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };


if (CheckMatrix(array1, array2))
{
    int[,] matrixMultiplay = MatrixMultiplay(array1, array2);
    Console.WriteLine("Результат умножения матриц");
    PrintMatrix(matrixMultiplay);
}
else Console.WriteLine("Ошибка! Размеры матриц не подходят для умножения.");





bool CheckMatrix(int[,] array1, int[,] array2)// проверка условия возможности умножить матрицы ---------
{
    int col1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    return col1 == row2;
}// ---------------------------------------------------------------------------------------------------



int[,] MatrixMultiplay(int[,] array1, int[,] array2) // умножение матриц ---------------------------
{
    int row1 = array1.GetLength(0);
    int col1 = array1.GetLength(1);
    int col2 = array2.GetLength(1);
    int[,] res = new int[row1, col2];
    for (int j = 0; j < col2; j++)
    {
        for (int i = 0; i < row1; i++)
        {
            for (int k = 0; k < col1; k++)
            {
                res[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return res;
}

int[,] CreatureRndArray(int row, int col, int min, int max)  // создание rnd массива ---------------------
{
    Random rand = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
} //-------------------------------------------------------------------------------------------------


void PrintMatrix(int[,] array)  // вывод двумерного массива в консоль --------------------------------
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        Console.Write("|");
        for (int j = 0; j < col; j++)
        {
            Console.Write("{0,5}", array[i, j]);
        }
        Console.WriteLine("   |");
    }
} //-------------------------------------------------------------------------------------------------