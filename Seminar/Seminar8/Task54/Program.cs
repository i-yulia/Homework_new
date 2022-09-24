// Д/з Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] SortRows(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < myArray.GetLength(1); k++)
            {
                if (myArray[i, j] < myArray[i, k])
                {
                    int temp = myArray[i, j];
                    myArray[i, j] = myArray[i, k];
                    myArray[i, k] = temp;
                }
            }
        }
    }
    return myArray;
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
SortRows(myArray);
Console.WriteLine();
PrintArray(myArray);
