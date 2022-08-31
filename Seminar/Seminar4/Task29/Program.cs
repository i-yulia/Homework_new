// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// Беру числа 15, 0, 100. 
//5, 0, 20 -> [1, 2, 5, 7, 19]
//3, 1, 35 -> [6, 1, 33]

int[] InitArray()
{
    int[] arr = new int[15];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}
Console.WriteLine(String.Join(", ", InitArray()));
