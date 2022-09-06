//Задача № 1/Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//Принимаем некий массив и показываем зеркально
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int [] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
 
int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}

myArray = ReverseArray(myArray);
ShowArray(myArray);
*/

//Задача № 2 
//Напишите программу, которая принимает на вход три числа и проверяет(method gives back boolean number), может ли существовать треугольник с сторонами такой длины.
//Сумма любых двух сторон всегда была больше другой стороны (a < b + c) (b < a + c) (c < b + a)
/*
bool Triangle(int num1, int num2, int num3)
{
    if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true;
    else return false;
}
Console.Write("Insert the first side of the triangle: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the second side of the triangle: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the third side of the triangle: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Does the 3 sided triangle exist {number1} {number2} {number3} - {Triangle(number1, number2,number3)}");

*/
// Задача № 3 - Не используя рекурсию, выведите первые N чисел Фибоначчи.(каждая следующая сумма двух предыдущих) 
//Первые два числа Фибоначчи: a и b. F(n) = F(n-1) + F(n-2)
/*
void Fibonachi(int numN, int numA, int numB)
{
    int temp = 0;
    Console.Write($"{numA} {numB} ");
    for(int i = 0; i < numN; i++)
    {
        temp = numA + numB;
        numA = numB;    
        numB = temp;
        Console.Write(numB + " ");
    }
}
Console.Write("Введите первые N чисел Фибоначи: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число Фибоначи: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число Фибоначи: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Fibonachi(number, numberA, numberB);
*/

//Задача № 4 - Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string Binary(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    
    return result;
}
Console.Write("Insert number: ");//консоль для введения пользователем числа
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write(Binary(numberB));
*/
////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////Homework///////////////////////////////////////////////////

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int[] CreateMyArray(int size)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Insert {i+1} number: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void ShowNumber(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >0) result++;
    Console.Write($"There are {result} numbers bigger than 0: ");
}
Console.Write("How many numbers do you want to insert?: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateMyArray(size);
ShowArray(myArray);
Console.WriteLine();
ShowNumber(myArray);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindPoint(double a, double c, double b, double d)
{
    // for(int i = 0; i < array.Length; i++)
    //     Console.Write(array[i] + " ");
    // Console.WriteLine();
    double x = (d-c) / (a-b);
    double y = a * x + c;
    if(a == b)
        Console.Write("Прямые параллельны");
    else
        Console.Write($"Точка пересечения двух прямых: x: {x}, y: {y}");
}

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

FindPoint(k1, b1, k2, b2);