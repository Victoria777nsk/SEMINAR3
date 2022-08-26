// Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine ("Введите номер четверти: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

if (quarterNumber == 1)
{
    Console.WriteLine("X > 0, Y > 0");
}
else if (quarterNumber == 2)
{
    Console.WriteLine("X < 0, Y > 0");
}
else if (quarterNumber == 3)
{
    Console.WriteLine("X < 0, Y < 0");
}
else if (quarterNumber == 4)
{
    Console.WriteLine("X > 0, Y < 0");
}
else
{
    Console.WriteLine("Ошибка!");
}
