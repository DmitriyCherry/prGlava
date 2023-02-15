/* Напишите программу, которая принимает на вход число и выдает количество цифр в числе.*/


/*int NumDigits (int value) <--- (Метод для верхнего условия)
{
    int divResult = value / 10;
    int sum = 1;
    
    for (int i = 0; divResult > 0; i++)
    {        
        sum++; 
        divResult = divResult / 10;
    }  
    return sum;
}*/



/* Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.*/


/*int MultNum (int arg)
{
    int count = 1;
    for (int i = 1; i <= arg; i++)
    {
        count *= i;
    }
    return count;
}

Console.Write("Введите любое целое число: ");
int count = int.Parse(Console.ReadLine()!);
int result = MultNum(count);
Console.WriteLine(result);*/



/* Напишите программу, которая выыодит массив из 8 элементов, заполненный нулями и единицами
в случайном порядке*/


void MyArray(int [] arr)
{
int elements = 8;
int [] myArr = new int [elements];
string thing = ", ";
for (int i = 0; i < elements; i++)
{
    myArr[i] = new Random().Next(0, 2);
    if (i == elements - 1)
    {
        Console.Write(myArr[i]);
    } else
    {
        Console.Write(myArr[i] + thing);
    }   
}
}

int[] Arr = new int [8];
MyArray(Arr); 