// д/з Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
            result[i, j] /= 1000;
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение ");
int max = int.Parse(Console.ReadLine());
double[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);