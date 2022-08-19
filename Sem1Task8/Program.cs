//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Insert number");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (number <=1)

{
    Console.WriteLine("Insert number greater than 1");
} 
else
{
    Console.Write($"All even numbers from 1 to {number}:");
}
while (i <= number)
{
    Console.Write(i + " ");
    i = i+2;
}

    