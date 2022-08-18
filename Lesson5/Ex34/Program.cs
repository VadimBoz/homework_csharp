// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] CreatureRndArray(int amount, int min, int max)
{
    Random rand = new Random();
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}


int FindParityDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;

    }
    return count;
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



int[] arr = CreatureRndArray(4, 100, 999);
PrintArray(arr);
int res = FindParityDigits(arr);
Console.WriteLine();
Console.WriteLine($"количество четных чисел в массиве составляет {res}");