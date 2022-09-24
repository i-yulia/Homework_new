// Д/з Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int[] RowsSum(int[,] array)
{
    int[] rowsSum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowsSum[i] += array[i, j];
        }
    }
    return rowsSum;
}

int MinRowSum(int[] rowSumArray)
{
    int minimumSum = rowSumArray[0];
    int minimumRow = 0;
    for (int i = 1; i < rowSumArray.Length; i++)
    {
        if (rowSumArray[i] < minimumSum)
        {
            minimumSum = rowSumArray[i];
            minimumRow = i;
        }
    }
    return minimumRow;
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
int[] rowsSum = RowsSum(myArray);
int minRow = MinRowSum(rowsSum);
Console.WriteLine($"Наименьшая сумма элементов в строке: {minRow}");