// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void PrintSecond()
{
    Console.Write("Введите трехзначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    for (int a = -1; x < 0; x = a * x) ;
    if (x < 1000 && x > 99)
    {
        int y = x % 100 / 10;
        Console.WriteLine(y);
    }
    else
        Console.WriteLine("Число должно быть целым, трехзначным");
}
try
{
    PrintSecond();
}
catch
{
    Console.WriteLine("Вводите только целые, трехзначные числа");
}