// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите натуральное  число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(number1, number2);
Console.WriteLine($"сумма натуральных чисел от {number1} до {number2}: {sum}");


int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num2 > num1)
        return num1 + SumNumbers(num1 + 1, num2);
    else return num2 + SumNumbers(num1, num2 + 1);
}