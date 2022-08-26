Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

switch (quarter)
{
    case 1: Console.WriteLine("X > 0, Y > 0"); break;
    case 2: Console.WriteLine("X < 0, Y > 0"); break;
    case 3: Console.WriteLine("X < 0, Y < 0"); break;
    case 4: Console.WriteLine("X > 0, Y < 0"); break;
    default: Console.WriteLine("Введена неправильная четверть"); break;
}
