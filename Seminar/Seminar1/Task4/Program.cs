// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите первое число: ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (numberB > max)
    max = numberB;
if (numberC > max)
    numberC = max;
Console.Write($"Максимальное число = {max}");

