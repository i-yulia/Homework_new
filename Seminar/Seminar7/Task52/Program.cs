// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
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
double[] FindAverage(int[,] array2)
{
    int rows = array2.GetLength(0);
    int cols = array2.GetLength(1);
    double[] average = new double[cols];
    double Sum = 0;

    for (int j = 0; j < cols; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            Sum += array2[i, j];
        }
        average[j] = Sum / rows;
        Sum = 0;
    }
    return average;
}
Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение ");
int max = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
double[] averageArray = FindAverage(myArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", averageArray)}");
