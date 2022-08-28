// Задача 21/ Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("введите х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("введите z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("введите х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("введите z2: ");
int z2 = int.Parse(Console.ReadLine());
int x = (x1 - x2) * (x1 - x2);
int y = (y1 - y2) * (y1 - y2);
int z = (z1 - z2) * (z1 - z2);
int sum = x + y + z;
double result = Math.Sqrt(sum);
Console.Write($"{result:f2}");
