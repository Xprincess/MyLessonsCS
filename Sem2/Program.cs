﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
/*
int FindBiggerDigit (int number)
{
    int ed = number % 10;
    int dec = number  / 10;

    int max;
    if(ed > dec) max = ed;
    else max = dec;

    return max;
}
/*
Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1



int randNumber = new Random().Next(10, 100);
int BiggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"BiggerDigit of {randNumber} is {BiggerDigit}");











//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

/*/
// int Method (int num) //135
// {
//     int ed = num % 10;
   
//     int hun = num / 100;
//     int result = hun * 10 +ed;
//     return result;

// }

// int randNumber = new Random().Next(100,1000);
// int number - Method(randNumber);
// Console.WriteLine ($ "answer is {number}");

/*/

//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
void Twonumbers(int number);
int number1;
int number2;
if(number2/number1 ==0)
{
    Console.WriteLine(" nothing ");
}
else
{
    dif = number2 %number1
}
/*/