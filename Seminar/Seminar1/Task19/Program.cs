// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int temp = number / 10;
int temp2 = number / 1000;
if (number / 10000 == number % 10 && temp % 10 == temp % 10)
{
    Console.Write($"Число является палиндромом");
}
else
{
    Console.Write($"Число не является палиндромом");
}