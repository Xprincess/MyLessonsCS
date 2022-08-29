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


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
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



