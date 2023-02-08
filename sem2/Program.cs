// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую
// цифру этого числа.

int randomNumber = new Random().Next(100, 1000);
int firstDigit = randomNumber / 100;

int firstTwoDigit = randomNumber / 10;
int secondDigit = firstTwoDigit % 10;

int thirdDigit = randomNumber % 10;

Console.Write($"Вывод крайних цифр из случайно сгенерированного трёхзначного числа {randomNumber}: {firstDigit}{thirdDigit}");
