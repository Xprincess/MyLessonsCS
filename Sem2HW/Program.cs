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
    string numberText = Convert.ToString(number);//Превращаем int - string, , 
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

/*
void Week(int number)
{
    if (number > 5)
        Console.WriteLine($"Today is {number} - weekend.");
    else
        Console.WriteLine($"Today is  {number} - it's a weekday.");
    if (number > 7)
        Console.WriteLine($"Today {number} - it's not a day of the week!");

}

Console.Write("Insert the number of the day (1-7): ");
int num = Convert.ToInt32(Console.ReadLine());//ReadLine always reads the input from the user in the form of a string. 
//To get an integer value from the user, this string needs to be converted to Integer. The Convert. ToInt32 does this.

Week(num);
*/

// //Второе решение задачи 15
// void Week (int number)

// {
//     if( number == 1) Console.WriteLine ("Monday");
//     if( number == 2) Console.WriteLine ("Tusday");
//     if( number == 3) Console.WriteLine ("Wednesday");
//     if( number == 4) Console.WriteLine ("Thursday");
//     if( number == 5) Console.WriteLine ("Friday");
//     if( number == 6) Console.WriteLine ("Saturday");
//     if( number == 7) Console.WriteLine ("Sunday");

// }

// Console.WriteLine("Insert a day of the week");
// int numb = Convert.ToInt32(Console.ReadLine());
// Week (numb);