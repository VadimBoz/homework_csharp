// Задача 7: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзачное целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1000 &&  n > 99)
{
    int lastNumber = n % 10;
    Console.WriteLine($"последняя цыфра числа {n} является: {lastNumber}");
}
else if (n < -99 &&  n > -1000)
{
    int lastNumber = -n % 10;
    Console.WriteLine($"последняя цыфра числа {n} является: {lastNumber}");

}
else
{
   Console.WriteLine("введите корректное число ");  
}