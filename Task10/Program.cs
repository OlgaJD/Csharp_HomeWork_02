// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int PrintSecond()
{
    Console.Write("Введите трехзначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x < 0)
        x = -x;
    int y = x % 100 / 10;
    return y;
}
Console.WriteLine(PrintSecond());