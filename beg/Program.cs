/*Console.Write("Введите число, которое нужно возвести в квадрат: ");
double value = double.Parse(Console.ReadLine()!);
double result = Math.Pow(value, 2);
Console.WriteLine($"Квадрат числа {value}, возведенного в квадрат, равен: {result}");*/




//Написать программу, которая будет выдавать название дня недели по заданному номеру.

/*Console.Write("Введите число, соответствующее дню недели: ");
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
} */




//Написать программу, которой на вход сообщается какое-то число n. После программа должна 
//давать на выходе все целые числа [-n;n];


/*Console.Write("Введите переменную, задающую интервал в пределах своего отрицательного и положительного значения: ");
int n = int.Parse(Console.ReadLine()!);
int inverseValue = n*(-1);
int stopCount = n*2;
for (int i = 0; i <= stopCount; i++)
{
    Console.Write($" {inverseValue}");
    inverseValue++;
}*/



//Написать программу, которая принимает на вход трехзначное число и выводит последнюю цифру этого числа.

Console.Write("Введите любое целое трехзначное число: ");
int count = int.Parse(Console.ReadLine()!);
int remainder = count % 10;
Console.WriteLine("Третья цифра будет: " + remainder);
