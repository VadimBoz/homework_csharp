// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3 n = 2 -> A(m,n) = 29


Console.Write("Введите число m: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int res = Akkerman(number1, number2);
Console.WriteLine($"Результат функции  Аккермана: {res}");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}