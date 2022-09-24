// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void ProductMatrix(int[,] prodMatrix, int[,] firstMatrix, int[,] secondMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(1); k++)
            {
                prodMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
}
Console.Write("Введите количество строк первой матрицы: ");
int arrayRows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int arrayColumns1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int arrayRows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int arrayColumns2 = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = int.Parse(Console.ReadLine());
int[,] matrix1 = GetArray(arrayRows1, arrayColumns1, arrayStart, arrayEnd);
int[,] matrix2 = GetArray(arrayRows2, arrayColumns2, arrayStart, arrayEnd);
int[,] productionMatrix = new int[arrayRows1, arrayColumns2];

Console.WriteLine("Первая матрица:");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);

if (arrayColumns1 == arrayRows2)
{
    ProductMatrix(productionMatrix, matrix1, matrix2);
    Console.WriteLine("\nПроизведение матриц:");
    PrintArray(productionMatrix);
}
else Console.WriteLine("\nНельзя найти произведение матриц.");
