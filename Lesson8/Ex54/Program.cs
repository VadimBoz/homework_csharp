// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = CreatureRndArray(4, 5, 0, 50);
Console.WriteLine("Исходный массив");
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив в строках");
SortMatrix(array);
PrintMatrix(array);

void SortMatrix(int[,] matrix) // сортировка выбором по убыванию элементов строк матрицы ------------
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int temp = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col - 1; j++)
        {
            for (int k = j + 1; k < col; k++)
            {
                if (matrix[i, k] > matrix[i, j])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}//------------------------------------------------------------------------------------------


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
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine("   |");
    }
} //-------------------------------------------------------------------------------------------------