// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Ведите количество чисел для ввода");
int count = Convert.ToInt32(Console.ReadLine());

int[] num = InputNumbers(count);
PrintArray(num);
int countPozitive=PozitiveCount(num);
Console.WriteLine($"Количество положительный чисел составляет: {countPozitive}");




int[] InputNumbers(int count) //чтение вводимых чисел ------------------------------------------
{ 
    Console.WriteLine($"Ведите {count} числа через [ENTER]");
    int[] input = new int[count];
    for (int i = 0; i < count; i++)
    {
        input[i] = Convert.ToInt32(Console.ReadLine());
    }
    return input;
}//-------------------------------------------------------------------------------------------------


void PrintArray(int[] array)  //вывод массива в консоль ------------------------------------------
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($" {array[array.Length - 1]}");
    Console.WriteLine("]");
} //-------------------------------------------------------------------------------------------------


int PozitiveCount(int[] array) //подсчет чисел больше нуля ------------------------------------------
{int res=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0) res++;
}
return res;
}//-------------------------------------------------------------------------------------------------


