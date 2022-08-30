// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] array = CreatureRndArray(6, 3, 0, 5);
Console.WriteLine("Исходный массив");
PrintMatrix(array);
Console.WriteLine();
int res = FindRow(array);
Console.WriteLine($"Строка с наименьшей суммной элементов: {res + 1}");


int FindRow(int[,] array) //поиск строки с наименьшей суммой --------------------------------
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int res = 0;
    int minSum = 99999;
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            res = i;
        }
    }
    return res;
}//й -----------------------------------------------------------------------------------------------



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