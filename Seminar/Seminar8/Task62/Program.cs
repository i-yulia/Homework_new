// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void SpiralMatrix(int row, int column, int[,] array)
{
    int lastRow = array.GetLength(0) - 1, lastColumn = array.GetLength(1) - 1;
    int point = 1;

    while (row <= lastRow && column <= lastColumn)
    {
        for (int i = column; i <= lastColumn; i++)
        {
            array[row, i] = point;
            point++;
        }
        row++;

        for (int i = row; i <= lastRow; i++)
        {
            array[i, lastColumn] = point;
            point++;
        }
        lastColumn--;

        if (row <= lastRow && column <= lastColumn)
        {
            for (int i = lastColumn; i >= column; i--)
            {
                array[lastRow, i] = point;
                point++;
            }
            lastRow--;


            for (int i = lastRow; i >= row; i--)
            {
                array[i, column] = point;
                point++;
            }
            column++;
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int arrayRows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = int.Parse(Console.ReadLine());
int[,] newMatrix = new int[arrayRows, arrayColumns];
int startRow = 0, startColumn = 0;
SpiralMatrix(startRow, startColumn, newMatrix);
Console.WriteLine();
PrintMatrix(newMatrix);
