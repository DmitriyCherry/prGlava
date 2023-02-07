Console.Write("Введите число, которое нужно возвести в квадрат: ");
double value = double.Parse(Console.ReadLine()!);
double result = Math.Pow(value, 2);
Console.WriteLine($"Квадрат числа {value}, возведенного в квадрат, равен: {result}");
