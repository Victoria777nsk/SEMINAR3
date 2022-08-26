// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0, 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите X: ");
        int X = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите Y: ");
        int Y = Convert.ToInt32(Console.ReadLine());

        if (X > 0 && Y > 0)
        {
            Console.WriteLine("1 четверть");
        }
        else if (X < 0 && Y > 0)
        {
            Console.WriteLine("2 четверть");
        }
        else if (X < 0 && Y < 0)
        {
            Console.WriteLine("3 четверть");
        }
        else if (X > 0 && Y < 0)
        {
            Console.WriteLine("4 четверть");
        }
        else 
        {
            Console.WriteLine("Ошибка! X и Y НЕ могут быть равны 0");
        }
    }
}
