// Напишите программу, которая по заданному номеру четверти, показывает какой диапазон возможных
// координат точек в этой четверти (x и y).


/*Console.Write("Введите номер четверти: ");
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
}*/



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 2D-пространстве.


/*Console.WriteLine("Введите координаты для точки A: ");
Console.Write("Координата точки A по оси абсцисс: ");
double ax =  double.Parse(Console.ReadLine()!);
Console.Write("Координата точки A по оси ординат: ");
double ay =  double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты для точки B: ");
Console.Write("Координата точки B по оси абсцисс: ");
double bx =  double.Parse(Console.ReadLine()!);
Console.Write("Координата точки B по оси ординат: ");
double by =  double.Parse(Console.ReadLine()!);

double bc = Math.Pow(ax-bx, 2);
double ac = Math.Pow(ay-by, 2);

double result = Math.Sqrt(bc + ac);
double roundResult = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками будет равно: {roundResult}");*/



// Напишите программу, которая принимает на вход число (N) и выдаёт в таблицу квадратов
// чисел от 1 до N.


Console.Write("Введите число, определяющее конец диапазона: ");
int count = int.Parse(Console.ReadLine()!);
int firstCountDia = 1;
Console.Write(firstCountDia);

for (int i = firstCountDia + 1; i <= count; i++)
{
    Console.Write($", {Convert.ToInt32(Math.Pow(i, 2))}");
}
Console.Write(".");