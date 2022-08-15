// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число (основание степени): ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (показатель степени): ");
int degreeNumber = Convert.ToInt32(Console.ReadLine());

int RaisingDegree(int num, int degreeNum)
{
    int res = 1;
    for (int i = 1; i <= degreeNum; i++) res = res * num;
    return res;
}

int res = RaisingDegree(number, degreeNumber);
Console.WriteLine($"{number} в степени {degreeNumber} равно: {res}");