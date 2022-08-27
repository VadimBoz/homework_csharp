// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = CreatureRndArray(3, 4, 0, 10);
PrintMatrix(matrix);
double[] averageColoumn = AverageColoumn(matrix);
Console.Write("Среднее арифметическое каждого столбца:  ");
PrintArray(averageColoumn);


double[] AverageColoumn(int[,] array) //среднее арифметическое в столбце---------------------------------
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double[] resAverage = new double[col];

    for (int j = 0; j < col; j++)
    {
        double sum = 0;
        int i = 0;
        for (; i < row; i++)
        {
            sum += array[i, j];
        }
        resAverage[j] = sum / i;
    }
    return resAverage;
}//-------------------------------------------------------------------------------------------------------


int[,] CreatureRndArray(int row, int col, int min, int max)  // создание rnd массива ---------------------------
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


void PrintArray(double[] array)  //вывод одномерного массива в консоль ------------------------------------------
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0:N1}  ", array[i]);
    }
    Console.Write("{0:N1}", array[array.Length - 1]);
    Console.WriteLine("]");
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
        Console.WriteLine("  |");
    }
} //-------------------------------------------------------------------------------------------------