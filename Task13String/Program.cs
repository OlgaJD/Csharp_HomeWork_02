// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

try
{
    void PrintThirdDigit()
    {
        Console.Write("Введите число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int a = -1; x < 0; x = a * x) ;
        if (x < 100)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            string num = x.ToString();
            int n = num.Length;
            Console.WriteLine(num[2]);
        }
    }
    PrintThirdDigit();
}
catch
{
    Console.WriteLine("Вводите только целые числа");
}