
//Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Insert the first number: ");
int numbera = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("The first number is " + numbera);

Console.WriteLine("Insert the second number: ");

int numberb = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("The second number is " + numberb);

Console.WriteLine("Insert the third number: ");
int numberc = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("The third number is " + numberc);

if (numbera = int.MaxValue)
{
    Console.WriteLine ("The biggest number is" + int.MaxValue);
}
else if (numberb = int.MaxValue)
{
    Console.WriteLine ("The biggest number is" + int.MaxValue);
}
else if (numberc = int.MaxValue)
{
    Console.WriteLine ("The biggest number is" + int.MaxValue);
}
//не работает, не понимаю как вывести максимальное число