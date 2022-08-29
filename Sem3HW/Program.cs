//1.Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuadrant (double x, double y)
{
if (x > 0 && y > 0) return 1;
if (x < 0 && y > 0) return 2;
if (x < 0 && y < 0) return 3;
if (x > 0 && y < 0 ) return 3;
return 0;
}
Console.Write("Input X coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

var quadrant = FindQuadrant(xA, yA);
Console.WriteLine("Num of quad is " + quadrant);
*/

//2.Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void FindCoordinateXY(double x, double y) // Метод для поиска номера четверти по координатам точки
{
    if (x > 0 && y > 0) Console.WriteLine("The point in the first quarter"); // Точка в первой четверти
    if (x < 0 && y > 0) Console.WriteLine("The point in the second quarter"); // Точка во второй четверти
    if (x < 0 && y < 0) Console.WriteLine("The point in the third quarter"); // Точка в третьей четверти
    if (x > 0 && y < 0) Console.WriteLine("The point in the fourth quarter"); // Точка в четвертой четверти
    if (x == 0 || y == 0) Console.WriteLine("The point on the coordinate axis"); // Точка лежит на оси координат
}
Console.WriteLine("Enter the coordinate X:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y:");
double yA = Convert.ToDouble(Console.ReadLine());
FindCoordinateXY(xA, yA);

*/

//3.Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.
/*
void SquareNumbers(int number) // Метод для вывода квадратов чисел от 1 до n
{
    int counter = 1;
    int square;
    while(counter <= number)
    {
        square = counter * counter;
        counter++;
        Console.Write(square + " ");
    }
}
Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
SquareNumbers(number);
*/


//4.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. Math.Sqrt()
/*
double FindDistance(double xA, double yA, double xB, double yB) // Метод для нахождения расстояния между двумя точками, теорема Пифагора (Корень квадратный из суммы квадратов катетов)
{
    double dist = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA)); // Метод Math.Sqrt() - возвращает корень квадратный выражения или числа
    return dist;
}
Console.WriteLine("Enter the coordinate X the point A:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y the point A:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate X the point B:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y the point B:");
double yB = Convert.ToDouble(Console.ReadLine());
double dist = FindDistance(xA, yA, xB, yB);
Console.WriteLine("Distance between A and B: " + dist);
*/
//HW
//Задача № 1 (решение 1) Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Polindron(int num) //Метод для проверки числа на полиндром
{
    int ed;
    int dec;
    int dec1;
    int south;
    int south1;
    int decSouth;
    ed = num % 10;
    dec = num % 100;
    dec1 = dec / 10;
    south = num / 1000;
    south1 = south % 10;
    decSouth = num / 10000;
    if (south1 == dec1 && decSouth == ed) return true;
    else return false;
}
Console.WriteLine("Th program to check if the number is polindron");
Console.Write("Insert a number: ");
int number = Convert.ToInt32(Console.ReadLine()); 
String otvet = Convert.ToString(Polindron(number));
if(otvet == "False") Console.WriteLine("No,the number isn't polidron");
else Console.WriteLine("Yes, it's polindron");
*/

//Задача № 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDist3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double squadX = Math.Pow(xB - xA, 2); // Возводим в квадрат разницу между координатами точки B и А
    double squadY = Math.Pow(yB - yA, 2); 
    double squadZ = Math.Pow(zB - zA, 2);
    double dist3D = Math.Sqrt(squadX + squadY + squadZ); //Метод получения растояния от точки A и Б
    return dist3D;
}
Console.Write("Enter the coordinate X the point A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Y the point A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Z the point A: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate X the point B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Y the point B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Z the point B: ");
double zB = Convert.ToDouble(Console.ReadLine());
double dist = FindDist3D(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Distance between A and B in 3D space: " + dist);
*/
//Задача № 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableCubeNumbers(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        double numberCube = Math.Pow(counter, 3);
        Console.Write(numberCube + " ");
        counter++;
    }
}
Console.WriteLine("Таблица кубических чисел от 1 до N");
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
TableCubeNumbers(number);
*/
