//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int number2 = number % 1000;
if (-99 > number || number > 99)
{
    if (number < -99)
    {
        Console.Write($"{number2 / 100 * -1}");
    }

    else
    {
        Console.Write($"{number2 / 100} ");
    }
}
else
{
    Console.Write($"третьей цифры нет ");
}
