// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreatureRndArray(int amount, int min, int max) // создание массива из заданного колва чисел --------
{
    Random rand = new Random();
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
} //---------------------------------------------------------------------------------------------------


int SumDigits(int[] array) //сумма элементов, стоящих на нечётных позициях (индексах)---------------
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
} //---------------------------------------------------------------------------------------------------


void PrintArray(int[] array) //вывод массива  консоль ----------------------------------------------
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
} //---------------------------------------------------------------------------------------------------



int[] arr = CreatureRndArray(5, -99, 99);
Console.WriteLine();
PrintArray(arr);
int res = SumDigits(arr);
Console.WriteLine();
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях (индексах): {res}");
Console.WriteLine();