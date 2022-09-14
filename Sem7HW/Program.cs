////////////////////////////////////////////////////////////////////////////////////////////////////
                                    //SEMINAR 7//
 ///////////////////////////////////////////////////////////////////////////////////////////////////
//Task 1//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//////////////////////////Первый вариант (с аргументами)///////////////////////////////////////////
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns]; //выделили память

    for(int i = 0; i < rows; i++) //заполняем массив
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}                  
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();

}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possibe value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] new2dArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(new2dArray);
*/
/////////////////////////////////Второй вариант (без аргументов)//////////////////////////////////
/*
int[,] CreateRandom2dArray( )
{
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possibe value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns]; //выделили память

    for(int i = 0; i < rows; i++) //заполняем массив
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}                  
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] new2dArray = CreateRandom2dArray();
Show2dArray(new2dArray);
*/
//Task2//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
/////////Выведите полученный массив на экран.
/*
int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;   
        }
    }
    
    return newArray;
}
void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2Array(m, n);
ShowArray2(newArray);
*/
//Task3//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}
void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
int[,] Switch (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+2)
    {
        for(int j = 0; j < array.GetLength(1); i+2)
        {
           array[i,j] = array[i,j] * array[i,j];
        }
    }
    return array;
}
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateRandom2Array(m, n, min, max);
ShowArray2(newArray);
Console.WriteLine();
int[,] switchArray = Switch(newArray);
ShowArray2(switchArray);
*/
//Task4//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
/////////(с индексами (0,0); (1;1) и т.д.(целочисленный двумерный массив, на выходе - просто int)

  








////////////////////////////////////////////////////////////////////////////////////////////////////
                                    //HOMEWORK 7//
 ///////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandome2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] newArray = new double[rows, colums];
    Random rand = new Random ();
    for(int i = 0; i < rows; i++)
    {   for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = Math.Round((rand.NextDouble() + rand.Next(minValue, maxValue + 1)), 2);
        }
    }       
    return newArray;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateRandome2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, colums];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue +1);
    
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
Console.Write("Input row's index: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column's index: ");
int colum = Convert.ToInt32(Console.ReadLine());
if (row > newArray.GetLength(0) || colum > newArray.GetLength(1))
    Console.WriteLine("This element doesn't exist");
else
    Console.WriteLine($"The element of row {row} and column {colum} is {newArray[row,colum]}");

*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandome2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, colums];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue +1);
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

void SumElementsEachColumn(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int n = array.GetLength(1);
        double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j];
        }

        average /= n;
        Console.WriteLine($"Averge of column  {j} is :  {average};");
     
    }

    Console.WriteLine();
}

int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
SumElementsEachColumn(newArray);