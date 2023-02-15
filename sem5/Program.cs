// Напишите программу замены элементов массива: положительные элементы замените на 
// соответствующие отрицательные.


/*void ReverseArr(int[] arg)
{    
    string thing = ", ";
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] *= -1;
        if (i == arg.Length - 1)
        {
            Console.Write(arg[i]);
        }else
        {
            Console.Write(arg[i] + thing);
        }
    }
}

Console.Write("Введите количество элементов нового массива: ");
int elements = int.Parse(Console.ReadLine()!);
int [] myArr = new int [elements];
string thing = ", ";
for (int i = 0; i < elements; i++)
{
    myArr[i] = new Random().Next(-9, 10);     
        if (i == elements - 1)
        {
            Console.Write(myArr[i]);
        }else
        {
            Console.Write(myArr[i] + thing);
        }
}
Console.WriteLine();
Console.Write("Тот же массив с противоположными знаками числовых элементов: ");
ReverseArr(myArr);*/



// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [...] --> нет


/*void FindArray(int arg1, int[] arg2)
{   
    int yesValue = 0;    
    for (int i = 1; i < arg2.Length + 1; i++)
    {        
        if (i == arg1)
        {
            yesValue += i;
        }
    }
    if (yesValue > 0)
    {
        Console.Write(" --> Да");
    }else 
    {
        Console.Write(" --> Нет");  
        //можно было вместо второй ифэлс задать брейк, так как нужно
        //просто узнать есть ли число, а не сколько раз оно там есть!
    }
}

Console.Write("Введите количество элементов нового массива: ");
int elements = int.Parse(Console.ReadLine()!);
int[] myArray = new int [elements];

for (int i = 0; i < elements; i++)
{
    myArray[i] = new Random().Next(2, 5);
    string thing = ", ";    
    if (i == 0)
        {
            Console.Write("[" + myArray[i] + thing);
        }else
        {
            if (i == elements - 1)
            {
                Console.Write(myArray[i] + "]");
            }else
        {
            Console.Write(myArray[i] + thing);
        }
        }            
}

FindArray(4, myArray);*/



// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10..99].


/*int SumNumArray (int [] arg)
{
    int sum = 0;  
    for (int i = 0; i < arg.Length; i++)
    {         
        if (arg[i] > 9 && arg[i] < 100)
        {
            sum++;
        }
    }
    return sum;
}

int[] myArr = new int [10];
for (int i = 0; i < myArr.Length; i++)
{
    string thing = ", ";
    myArr[i] = new Random().Next(1, 200);     
        if (i == 0)
        {
           Console.Write("[" + myArr[i] + thing);          
        }
        if (i != 0)
        {
            if (i == myArr.Length - 1)
            {
                Console.Write(myArr[i] + "]");
            }else
                {
                    Console.Write(myArr[i] + thing);
                } 
        }  
}
int result = SumNumArray(myArr);
Console.WriteLine($"--> {result}");*/



// Найдите произведение пар чисел в одномерном массиве. Пара - первый и последний,
// второй и предпоследний и т.д.


int[] myArr = 