// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int current = 2;


if (number < 1)
{
    Console.Write($"Неверно введено число ");
}
else
{
    while (current <= number)

    {
        Console.Write($"{current }");
        current = current + 2;

    }
}
   