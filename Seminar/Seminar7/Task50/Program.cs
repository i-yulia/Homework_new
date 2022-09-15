// Д/з Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// После нахождения первого числа с заданным значением функция завершает работу.
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
void FindNumber(int[,] array2, int number)
{
    int[] result2 = new int[2];

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)

            if (array2[i, j] == number)
            {
                Console.Write($"Заданное число имеет индекс: [{i},{j}] ");
                return;
            }
    }
    Console.WriteLine("Заданного числа нет в массиве.");
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
Console.WriteLine("Введите число для поиска: ");
int findNum = int.Parse(Console.ReadLine());
FindNumber(myArray, findNum);