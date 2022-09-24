// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] GetArray(int rows, int columns, int layers)
{
    int[,,] result = new int[rows, columns, layers];
    int num = 10;

    for (int i = 0; i < layers; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                result[i, j, k] = num;
                num++;
            }
        }
    }
    return result;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}
Console.Write("Введите количество строк: ");
int arrayRows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = int.Parse(Console.ReadLine());
Console.Write("Введите количество слоёв: ");
int arrayLayers = int.Parse(Console.ReadLine());
int[,,] array3D = GetArray(arrayRows, arrayColumns, arrayLayers);
PrintArray(array3D);
