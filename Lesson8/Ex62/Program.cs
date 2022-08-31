// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int row = 4;
int col = 4;

Console.WriteLine("перый способ");
int[,] array1 = CreationArray(row, col);
PrintMatrix(array1);

Console.WriteLine("второй способ");
int[,] res3 = CreationArray2(row, col);
PrintMatrix(res3);



int[,] CreationArray(int row, int col) //заполнение матрицы по спирали 1 способ-------------------------------------
{
    int[,] res = new int[row, col];
    int count = 1;
    int j = 0;
    int i = 0;
    int t = 0;
    while (count < row * col)
    {
        for (j = t; j < col - 1 - t; j++)
        {
            res[t, j] = count;
            count++;
        }
        for (i = t; i < row - t - 1; i++)
        {
            res[i, j] = count;
            count++;
        }
        for (j = col - t - 1; j > t; j--)
        {
            res[i, j] = count;
            count++;
        }
        for (i = row - t - 1; i > t; i--)
        {
            res[i, j] = count;
            count++;
        }
        t++;
    }
    if (col == row && col%2!=0) res[row / 2, col / 2] = count;

    return res;
} // ---------------------------------------------------------------------------------------------



int[,] CreationArray2(int row, int col) //заполнение матрицы по спирали 2 способ -------------------------
{
    int[,] res = new int[row, col];
    int count = 1;
    int j = 0;
    int i = 0;
    int t = 0;
    while (count <= row * col)
    {
        res[i, j] = count;
        if (i == t && j < col - 1 - t) j++;
        else if (j == col - 1 - t && i < row - t - 1) i++;
        else if (i == row - t - 1 && j > t) j--;
        else if (j == t && i > t + 1) i--;
        else if (j == t && i == t + 1) { t++; j++; }
        count++;
    }
    return res;
} // ---------------------------------------------------------------------------------------------


void PrintMatrix(int[,] array)  // вывод двумерного массива в консоль --------------------------------
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    string temp = "";
    for (int i = 0; i < row; i++)
    {
        Console.Write("|");
        for (int j = 0; j < col; j++)
        {
            if (array[i, j] < 10)
            {
                temp = "0" + Convert.ToString(array[i, j]);
                Console.Write("{0,5}", temp);
            }
            else Console.Write("{0,5}", array[i, j]);
        }
        Console.WriteLine("   |");
    }
} //-------------------------------------------------------------------------------------------------

