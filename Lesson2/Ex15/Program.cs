// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Ведите порядковый номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

void weekend_check(int n)
{
    if (n >= 6 && n <= 7)
    {
        Console.WriteLine("Да");
    }
    else if (n >= 1 && n <= 5)
    {
        Console.WriteLine("Нет");
    }
    else Console.WriteLine("Введено не верное чило");
}
weekend_check(number);