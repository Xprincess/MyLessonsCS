
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Insert the first number: ");
int numbera = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("The first number is " + numbera);

Console.WriteLine("Insert the second number: ");

int numberb = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("The second number is " + numberb);

if (numbera > numberb)
{
    Console.WriteLine ("The first number is bigger than the second one");
}
else if (numbera < numberb)
{
    Console.WriteLine ("The second number is bigger than the first one");
}