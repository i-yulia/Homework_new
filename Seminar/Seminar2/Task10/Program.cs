//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("введите трехзначное число: ");
int number1 = int.Parse(Console.ReadLine());
if (number1 > -1000 && number1 < -99 || 99 < number1 && number1 < 1000)
{
    int number2 = number1 / 10;
    int number3 = number2 % 10;
    {
        if (number1 > -1000 && number1 < -99)

        {
            Console.Write($"{number3 * -1}");
        }

        else
        {
            Console.Write($"{number3}");
        }
    }
}
else
{
    Console.Write($"неверное число ");
}

