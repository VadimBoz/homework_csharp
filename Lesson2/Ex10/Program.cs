// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Ведите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int n)
{
    if (n > 99 && n < 1000)
    {
        return (n / 10) % 10;
    }
    else return -1;
   
}

int SecondDigit = ShowSecondDigit(number);

if (SecondDigit == -1) Console.WriteLine("Введено не трехзначное число");
else Console.WriteLine($"Вторая цыфра числа {number} равна {SecondDigit}");