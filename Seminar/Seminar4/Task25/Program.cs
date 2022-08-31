// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5-> 243(3⁵)

int NumPower(int number1, int number2)
{
    int power = 1;
    for (int i = 1; i <= number2; i++)
    {
        power = power * number1;
    }
    return power;
}
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int Power = NumPower(numberA, numberB);
Console.WriteLine($"{(Power)}");
