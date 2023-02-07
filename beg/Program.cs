/*Console.Write("Введите число, которое нужно возвести в квадрат: ");
double value = double.Parse(Console.ReadLine()!);
double result = Math.Pow(value, 2);
Console.WriteLine($"Квадрат числа {value}, возведенного в квадрат, равен: {result}");*/




//Написать программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите число, соответствующее дню недели: ");
int value = int.Parse(Console.ReadLine()!);
if (value == 1)
{
    Console.Write("Этому порядковому номеру соответствует понедельник");
}
if (value == 2)
{
    Console.Write("Этому порядковому номеру соответствует вторник");
}
if (value == 3)
{
    Console.Write("Этому порядковому номеру соответствует среда");
}
if (value == 4)
{
    Console.Write("Этому порядковому номеру соответствует четверг");
}
if (value == 5)
{
    Console.Write("Этому порядковому номеру соответствует пятница");
}
if (value == 6)
{
    Console.Write("Этому порядковому номеру соответствует суббота");
}
if (value == 7)
{
    Console.Write("Этому порядковому номеру соответствует воскресенье");
}
else if (value < 1 || value > 7)
{
    Console.Write("Под таким порядковым номером дней недели еще не придумали...");
} 







