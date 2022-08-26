// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

Console.WriteLine($"A ({x1}, {y1}); B ({x2}, {y2}); AB = {result:f3}");

