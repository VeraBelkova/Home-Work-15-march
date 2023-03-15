// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты AX");
int AX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты AY");
int AY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты AZ");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты BX");
int BX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты BY");
int BY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты BZ");
int BZ = Convert.ToInt32(Console.ReadLine());

double number = Math.Sqrt(Math.Pow((AX - BX),2) + Math.Pow((AY - BY),2) + Math.Pow((AZ - BZ),2));
Console.WriteLine(number);