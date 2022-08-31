//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*

int FindSum(int num)
{
    int sum = 0;
    for (int current = 1; current <= num; current++)
        sum+= current;
    return sum;
}
Console.Write("Imput positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");
////Задача № 2 - Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int SizeNumber(int num)         //Метод для поиска количесва чисел в числе
{
    int size = 0;
    while (num > 0 || num < 0)  //В условии цикла могут быть как положительные, так и отрицательные числа
    {
        num = num / 10;         //Входящее число становиться на одно число числа меньше с каждым циклом
        size++;                 //Счётчик цифр числа
    }
    return size;
}
Console.Write("Imput integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Size of number {number} is {SizeNumber(number)}");
*/

//Задача № 3 - Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int FindFactorial(int num) //Метод возврата произведения чисел от 1 до N
{
    int current = 1;       //Счётчик
    int factorial = 1;        
    while(current <= num)
    {
        factorial = factorial * current;
        current++;
    }
    return factorial;
}
Console.Write("Imput integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {number} равно {FindFactorial(number)}");
*/

//Задача № 4 - Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
int[] CreateNewArray(int size)
{
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array, int minValue, int maxValue)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    } 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int [] randomNewArray = CreateNewArray(8);
FillArray(randomNewArray, 0, 1);
ShowArray(randomNewArray);

*/



//Homework 4

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// */
//Exponentiation is a mathematical operation, written as bⁿ, 
//involving two numbers, the base b and the exponent or power n, 
//and pronounced as "b raised to the power of n"
/*
int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Insert number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Insert number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("A raised to the power of B is : " + exponentiation);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int FindSum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

Console.Write("Imput positive integer number: ");
int result = Convert.ToInt32(Console.ReadLine());
int sum = FindSum (result);
Console.WriteLine($"Sum of numbers  is {sum}");

*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    
    int i = 0;

    while(i < size)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    return newArray;
}

void ShowArray( int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArray(SizeArray));

