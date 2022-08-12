// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Table_cube(int num)
{
    Console.WriteLine(" Число\t  Куб числа\t");
    int res = 1;
    int i = 1;
    while (i <= num)
    {
        res = i * i * i;
        Console.WriteLine($"| {i} \t | {res}\t   |");
        i++;
    }
}

Table_cube(number);