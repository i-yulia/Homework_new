//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11

int SumNum(int num)
{
    int sum = 0;
    for (int i = 0; 0 < num; i++)
    {
        sum = sum + num % 10;

        num = num / 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int Sum = SumNum(number);
Console.WriteLine($"{SumNum(number)}");