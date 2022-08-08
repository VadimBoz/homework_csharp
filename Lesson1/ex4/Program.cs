// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double n3 = Convert.ToDouble(Console.ReadLine());

if ((n1 > n2 && n1 > n3) && (n2 != n3))
{
    Console.WriteLine($"максимальное число из {n1}, {n2}, {n3}  - {n1}");
}
else if ((n2 > n1 && n2 > n3) && (n1 != n3))
{
    Console.WriteLine($"максимальное число из {n1}, {n2}, {n3}  - {n2}");
}
else if ((n3 > n1 && n3 > n2) && (n1 != n2))
{
    Console.WriteLine($"максимальное число из {n1}, {n2}, {n3}  - {n3}");
}
else
{
    Console.WriteLine($"среди введеных чисел {n1}, {n2}, {n3} есть одинаковые");
}