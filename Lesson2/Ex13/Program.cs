// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

int TherdDigit(int n) //поиск третьей цифры числа-----------------------------------
{
    int i = 1;
    while (n > 999)
    {
        n = n / 10;
        i++;
    }
    if (n < 100) return -1;
    else
    {
    int n3 = n % 10;
    return n3;
    }
 
}//--------------------------------------------------------


int therdDigit = TherdDigit(number);
if (therdDigit==-1)  Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Третья цифра числа {number} равна {therdDigit}");