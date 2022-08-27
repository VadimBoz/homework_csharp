// Задача 50.Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого элемента в массиве нет


int[,] array = CreatureRndArray(6, 4, -10, 10);
PrintArray(array);
int[] index = IndexInput(2);
string res = IfElementExists(index, array);
Console.WriteLine(res);



string IfElementExists(int[] index, int[,] array) // проверка, есть ли элемент в массиве---------
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    if (index[0] >= row || index[1] >= col
    || index[0] < 0 || index[1] < 0) return "Такого элемента не существует";
    else
    {
        string str = $"Элемент массива c индексами [{index[0] + 1}, {index[1] + 1}]: ";
        return str + Convert.ToString(array[ index[0], index[1] ]);
    
    }
} //------------------------------------------------------------------------------------------------


int[] IndexInput(int count)  //  чтение с консоли индексов элемента массива
{
    Console.WriteLine();
    int[] res = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите {i + 1} индекc элемента ");
        res[i] = Convert.ToInt32(Console.ReadLine()) - 1;
    }
    return res;
} //----------------------------------------------------------------------------------------------------


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


void PrintArray(int[,] array)  // вывод массива в консоль --------------------------------
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


