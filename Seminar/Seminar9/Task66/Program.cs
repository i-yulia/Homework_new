// Д/з Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumRec(int m, int n)
{
   return m == n ? n : m + SumRec(++m, n);
}
Console.WriteLine("Введите число m: ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int numberN = int.Parse(Console.ReadLine());
int Sum = SumRec(numberM, numberN);
Console.WriteLine($"{Sum}");