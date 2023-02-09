// Напишите программу, которая по заданному номеру четверти, показывает какой диапазон возможных
// координат точек в этой четверти (x и y).


Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1)
{
    Console.WriteLine("Все точки лежат в диапазоне (x, y)");
}else if (num == 2)
{
    Console.WriteLine("Все точки лежат в диапазоне (-x, y)");
}else if (num == 3)
{
    Console.WriteLine("Все точки лежат в диапазоне (-x, -y)");
}else if (num == 4)
{
    Console.WriteLine("Все точки лежат в диапазоне (x, -y)");
}else
{
    Console.WriteLine("Такой четверти нет");
}