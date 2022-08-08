// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n_i = 2;
if (n < 2)
{
    Console.WriteLine("введите число более 1");
}
else
{
 Console.Write($"четные числа от 1 до {n} : ");
    while (n_i <= n)
    {
        if (n_i % 2 == 0)
        {
            Console.Write($" {n_i}");
        }
        n_i++;
    }
}