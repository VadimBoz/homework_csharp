// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = CreatureRndArray(5, 4, 4, 10, 99);
PrintArray(array);


int[,,] CreatureRndArray(int row, int col, int deep, int min, int max)  // создание rnd массива ---------------------
{
    Random rand = new Random();
    int[,,] array = new int[row, col, deep];
    int temp = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                temp = rand.Next(min, max + 1);
                while (IsExist(temp, array))
                {
                     temp = rand.Next(min, max + 1);
                }
                array[i, j, k] = temp;
            }
        }
    }
    return array;
} //-------------------------------------------------------------------------------------------------


bool IsExist(int num, int[,,] array) //проверка если совпадающее число в массиве
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int deep = array.GetLength(2);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                if (array[i, j, k] == num)
                    return true;
            }
        }
    }
    return false;
} //-------------------------------------------------------------------------------------



void PrintArray(int[,,] array)  // вывод трех мерного  массива в консоль --------------------------------
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int deep = array.GetLength(2);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                Console.Write($"({i}, {j}, {k}) {array[i, j, k]}   ");
            }
           Console.WriteLine(); 
        }
    }
} //-------------------------------------------------------------------------------------------------