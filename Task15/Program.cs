// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число от 1 до 7, соответствующее дню недели");
string day = Console.ReadLine();
switch (day)
{
    case "1":
        Console.WriteLine("Это не выходной (Понедельник)");
        break;
    case "2":
        Console.WriteLine("Это не выходной (Вторник)");
        break;
    case "3":
        Console.WriteLine("Это не выходной (Среда)");
        break;
    case "4":
        Console.WriteLine("Это не выходной (Четверг)");
        break;
    case "5":
        Console.WriteLine("Это не выходной (Пятница)");
        break;
    case "6":
        Console.WriteLine("Это выходной (Суббота)");
        break;
    case "7":
        Console.WriteLine("Это выходной (Воскреснье)");
        break;
    default:
        Console.WriteLine("Необходимо было ввести целое число не используя слова");
        break;
}