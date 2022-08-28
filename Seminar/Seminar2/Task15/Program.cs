// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите порядковый номер дня недели ");
int number = int.Parse(Console.ReadLine());

if (0 < number && number < 8)
{
    if (5 < number && number < 8)
    {
        Console.Write($"Выходной ");
    }

    else
    {
        Console.Write($"Будний");
    }
}
else
{
    Console.Write($"Неверное число ");
}
