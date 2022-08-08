// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double n2 = Convert.ToDouble(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"первое число {n1} больше второго {n2}");
}
else if (n2 > n1)
{
    Console.WriteLine($"второе число {n2} больше первого {n1}");
}
else 
{
    Console.WriteLine("введены одинаковые числа");
}