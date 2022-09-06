// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int OddSum(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        Sum += array[i];
    }
    return Sum;
}
Console.Write("Введите длину массива: ");
int arraySize = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = int.Parse(Console.ReadLine());
int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);
Console.WriteLine($"Массив: {String.Join(" ", newArray)}");
int oddSumArray = OddSum(newArray);
Console.WriteLine($"Сумма элементов на нечетных позициях: {String.Join(" ", oddSumArray)}");