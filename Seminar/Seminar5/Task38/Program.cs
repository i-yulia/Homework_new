// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

//[3 7 22 2 78] -> 76
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        res[i] /=10;
    }
    return res;
}

double MaxNum(double[] array)
{
    double maxim = array[0];
    foreach (double el in array)
    {
        if (el > maxim)
        maxim = el;
    }
    return maxim;
}

double MinNum(double[] array)
{
    double minim = array[0];
    foreach (double el in array)
    {
        if (el < minim)
        minim = el;
    }
    return minim;
}

Console.Write("Введите длину массива: ");
int arraySize = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = int.Parse(Console.ReadLine());
double[] newArray = GetArray(arraySize, arrayStart, arrayEnd);
Console.WriteLine($"Массив: {String.Join(" ", newArray)}");
double maxim = MaxNum(newArray);
Console.WriteLine($"Максимальное число: : {String.Join(" ", maxim)}");
double minim = MinNum(newArray);
Console.WriteLine($"Минимальное число: : {String.Join(" ", minim)}");
Console.WriteLine($"Разница: : {String.Join(" ", maxim - minim)}");