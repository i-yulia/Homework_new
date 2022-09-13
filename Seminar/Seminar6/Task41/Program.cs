// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int [] UserArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int ColNum(int[] arr)
{
    int col = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            col++;
    }
    return col;
}
Console.WriteLine("Введите M, обозначающее количество чисел: ");
int numberM = int.Parse(Console.ReadLine());

int[] ArrayM = UserArray(numberM);
int result = ColNum(ArrayM);
Console.WriteLine($"Количество чисел больше 0: {result}");