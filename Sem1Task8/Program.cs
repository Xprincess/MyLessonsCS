//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine ("Insert number: ");

int number =Console.ToInt32 (Console.ReadLine());

for ( int i=0; i<=20; i++) 
{
if (i%2 == 0) {
Console.Write( "{0} " , i);
}
}

 
for (int x = 2; x < 101; x++)       
if (x%2==0)            
Console.WriteLine(x);