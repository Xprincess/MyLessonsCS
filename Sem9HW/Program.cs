﻿//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////Homework 9/////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//-----------------------------------------
// ----------- ДОМАШНЯЯ РАБОТА 9 ----------
//-----------------------------------------


//-----Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*int FindSumDigit(int m, int n)  
{
    if(m < n) return FindSumDigit(m+1,n)+m;
    else return m;
}
Console.Write(FindSumDigit(1,10));*/


//-----Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// //m = 2, n = 3 -> A(m,n) = 29 - не правильно дан результат, при m = 2, n = 3 -> A(m,n) = 9... а не как в условии 29!!!
//                                                         //  при m = 3, n = 2 -> A(m,n) = 29...!!!

// int AckermannFunction (int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
//     if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     return AckermannFunction(m, n);
// }

// Console.WriteLine(AckermannFunction(3,2));
















//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////Seminar 9/////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Task1//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.(рекурсия)
// void ShowNums(int n)
// {
//     if(n > 1) ShowNums(n - 1);

//     Console.Write(n + " ");

// }
// ShowNums(5);

//Задача №2 - Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. (Рекурсия)

// int SumOfDigits(int n)
// {
//     if(n > 0) return SumOfDigits(n / 10) + n % 10;
//     else return 0;
// }   


// Console.Write(SumOfDigits(5464)); 


//Задача №3 - Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNums(int m, int n)
// {   
    
//     if(n > m)
//     {
//         if(n > m) ShowNums(m, n - 1);
//         Console.Write(n + " ");
//     }
//     else
//     {
//         if(m > n) ShowNums(m, n + 1);
//         Console.Write(n + " ");
//     }
   
// }
// ShowNums(1, 9);

//Задача №4 - Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int PowValue(int a, int b)
// {
//     if(b > 1) return PowValue(a, b -1)*a;
//     else return a;
// }
// Console.WriteLine(PowValue(2,3));




