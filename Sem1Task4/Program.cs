﻿
//Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.SetCursorPosition(40, 1);

Console.WriteLine("Insert 3 numbers");

Console.Write("Insert the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number1 > max)
{
    max = number1;
}
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.Write($"Max number is {max} "); 
