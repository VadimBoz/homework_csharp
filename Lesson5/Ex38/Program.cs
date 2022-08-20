// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreatureRndArray(int amount) //создание массива вещественных чисел ------------------------------
{
    Random rand = new Random();
    double[] array = new double[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = rand.NextDouble() * 100;
    }
    return array;
} //-------------------------------------------------------------------------------------------------


double DifferenceMaxMin(double[] array) // определение разницы между  макс.  и мин. элементами массива
{
    double max = array[0];
    double min = max;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
} //-------------------------------------------------------------------------------------------------

void PrintArray(double[] array)  //вывод массива в консоль ------------------------------------------
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0:N2};  ",array[i]);
    }
    Console.Write("{0:N2}", array[array.Length - 1]);
    Console.WriteLine("]");
} //-------------------------------------------------------------------------------------------------

double[] arr = CreatureRndArray(5);
PrintArray(arr);
double res = DifferenceMaxMin(arr);
Console.WriteLine();
Console.Write("разница между макс. и мин. значениями:");
Console.WriteLine(" {0:N2}",res);