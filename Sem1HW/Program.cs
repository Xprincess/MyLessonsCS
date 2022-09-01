
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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
*/

//Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
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
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine ("Insert number: ");

int number = Convert.ToInt32 (Console.ReadLine ());

if (number % 2==0)

{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine ("Number isn't even");
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N
/*
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
*/

// Теперь, когда вы ознакомились с оператором if и конструкциями цикла на языке C#,
// попытайтесь написать код C# для поиска суммы всех целых чисел от 1 до 20, которые делятся на 3. Вот несколько подсказок:
// оператор % позволяет получить остаток от операции деления;
// оператор if предоставляет условие, которое позволяет определить, будет ли число учитываться в сумме;
// цикл for позволяет повторить последовательность шагов для всех чисел от 1 до 20.
// Попробуйте самостоятельно. Затем проверьте результат. Вы должны получить ответ "63".
/*
int sum = 0;
for (int number = 1; number < 21; number ++)
{
    if (number % 3 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine($"The number is {sum}");
*/