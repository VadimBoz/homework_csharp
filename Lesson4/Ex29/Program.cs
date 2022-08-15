// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] res = CreatureArray(8, 0, 100);
PrintArray(res);

//------------------------ methods ------------------------------
int[] CreatureArray(int amount, int min, int max)
{
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}