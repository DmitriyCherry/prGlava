// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую
// цифру этого числа.


/*int randomNumber = new Random().Next(100, 1000);
int firstDigit = randomNumber / 100;

int firstTwoDigit = randomNumber / 10;
int secondDigit = firstTwoDigit % 10;

int thirdDigit = randomNumber % 10;

Console.Write($"Вывод крайних цифр из случайно сгенерированного трёхзначного числа {randomNumber}: {firstDigit}{thirdDigit}");*/



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.


Console.WriteLine("Введите первое число: ");
int firstValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int secondValue = int.Parse(Console.ReadLine()!);

if (firstValue % secondValue == 0)
{
    Console.WriteLine($"{firstValue},{secondValue} -> кратно");
}else
{
    int result = firstValue % secondValue;
    Console.WriteLine($"{firstValue},{secondValue} -> {result}");
}