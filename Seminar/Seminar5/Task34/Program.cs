// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenNum(int[] arr)
{
    int counter = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0)
            counter++;
    }
    return counter;
}

int[] myArray = GetArray(20, 100, 999);
Console.WriteLine(String.Join(" ", myArray));

int result = EvenNum(myArray);
Console.WriteLine($"Количество четных чисел = : {result}");