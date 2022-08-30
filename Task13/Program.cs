// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

try
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    void SayThirdDigit()
    {
        int y;
        y = x % 10;
        Console.WriteLine($"{y} - третья цифра от заданного числа");
    }
    void MakeThreeDigitNumber()
    {
        while (99 < x && x > 1000)
            x = x / 10;
    }
    for (int a = -1; x < 0; x = a * x) ;
    switch (x)
    {
        case < 100:
            Console.WriteLine("Третьей цифры нет");
            break;
        case > 99 and < 1000:
            SayThirdDigit();
            break;
        case > 999:
            MakeThreeDigitNumber();
            SayThirdDigit();
            break;
    }
}
catch
{
    Console.Write("Вводите только целые числа, не используйте буквы");
}
