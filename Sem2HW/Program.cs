﻿// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int FindSecdigit (int number)//456
{
    int ed = number / 10;//456-убирется 6
    int hun = number % 100;//456 -убирется 4
    int result = ;//я не понимаю, как оставить цифру посередине и не понимаю, как внести в result вторую цифру
    return result;
}

int randNumber = new Random().Next(100, 1000);
int SecDig = FindSecdigit(randNumber);   
  
Console.WriteLine($"3 digit random number {randNumber}");     
Console.WriteLine($"Secdigit is {Secdig}");

//Программа не работает,,

*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// //что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
void ThirdDigit(int number)
{
    string numberText = Convert.ToString(number);
    if (numberText.Length > 2)
        Console.WriteLine("The third digit is " + numberText[2]);
    else
        Console.WriteLine("The third digit doesn't exist");
}
Console.Write("Insert number: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDigit(num);

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


