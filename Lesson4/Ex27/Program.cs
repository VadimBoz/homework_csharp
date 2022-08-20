// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int res = num % 10;
    for (int n1 = num / 10; n1 > 0; n1 /= 10)
    {
        res += n1 % 10;
    }
    return res;
}


int sum = SumDigits(number);
Console.WriteLine($"сумма цифр в числе {number} = {sum}");