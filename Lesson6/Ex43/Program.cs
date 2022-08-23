// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine($"Ведите 4 коэффициента уравнений (b1, k1, b2, k2) через [ENTER]");
double[] coefficient = InputNumbers(4);
PrintArray(coefficient);
double[] res = PointIntersection(coefficient[0], coefficient[1], coefficient[2], coefficient[3]);

Console.WriteLine($"Точка пересечения прямых:");
PrintArray(res);


double[] InputNumbers(int count) //чтение вводимых чисел ------------------------------------------
{
    double[] inputNum = new double[count];
    for (int i = 0; i < count; i++)
    {
        inputNum[i] = Convert.ToDouble(Console.ReadLine());
    }
    return inputNum;
}//-------------------------------------------------------------------------------------------------


double[] PointIntersection(double b1, double k1, double b2, double k2) //точка пересечения 2х прямых -----------
{
   
    double[] point = new double[2];
    //  if (k1==k2) 
    // {
    //     return point = [-1,  2];
    // }
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;
} //-------------------------------------------------------------------------------------------------


void PrintArray(double[] array)  //вывод массива в консоль ------------------------------------------
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0:N1};  ",array[i]);
    }
    Console.Write("{0:N1}", array[array.Length - 1]);
    Console.WriteLine("]");
} //-------------------------------------------------------------------------------------------------