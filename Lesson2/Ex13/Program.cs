// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int DigitCount(int n)//определение числа разрядов заданного числа
{
    int depth = 1;
    int remains = n / 10;
    if (remains >= 1)
    {
        while (remains >= 1)
        {
            remains = remains / 10;
            depth = depth + 1;
        }
    }
    return depth;
}

int Digits_0(int depthLocal) //формирует чило 10... с заданным числом зазрядов
{
    int res = 1;
    for (int i = 1; i <= depthLocal; i++) res = res * 10;
    return res;
}

int TherdDigit(int n) //поиск третьей цифры числа
{
    n = (n / (Digits_0(DigitCount(n) - 3))) % 10;
    return n;
}

//------------------------------------------------------------------------------------
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
int digitCount = DigitCount(number);
if (digitCount < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int therdDigit = TherdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} равна {therdDigit}");
}