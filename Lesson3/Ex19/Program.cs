// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// --------------программа для проверки палиндрома числа произвольной длинны ------------------
Console.WriteLine("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());

bool PalindromCheck(long num)
{
    long remains = num;
    int i = 1; 
    long k = 1;
    while (remains >= 10)
    {
        remains = remains / 10;
        k = k * 10;
        i++;
    }

    long number1 = 1; 
    long number2 = 1; 
    long number3 = num * 10;
    int j = 0;
    while (j < i / 2)
    {
        number3 = number3 / 10;
        number1 = number3 % 10; // остаток с конца числа

        number2 = (num / (k)) % 10; // остаток с начала  числа
        k = k / 10;
      //  Console.WriteLine($"{number1} {number2} {number3} {i} {k}");
        if (number1 != number2) return false;
        j++;
    }
  return true;
}

if (PalindromCheck(number)) Console.WriteLine($"число {number} является палиндромом");
else  Console.WriteLine($"число {number} не является палиндромом");