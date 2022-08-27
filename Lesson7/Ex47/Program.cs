// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] array = CreatureRndArray(6, 4, -10, 10);
PrintArray(array);

double[,] CreatureRndArray(int row, int col, int min, int max)  // создание rnd массива ---------------------------
{
    Random rand = new Random();
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.NextDouble() * (max - min) + min;
        }
    }
    return array;
} //-------------------------------------------------------------------------------------------------

void PrintArray(double[,] array)  // вывод массива в консоль --------------------------------
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        Console.Write("|");
        for (int j = 0; j < col; j++)
        {
            Console.Write("{0,8:f2}", array[i, j]);
        }
        Console.WriteLine(" |");
    }
} //-------------------------------------------------------------------------------------------------