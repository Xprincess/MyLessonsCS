////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////HOMEWORK8////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////
//Task54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
/*
int[,] RandomArray2d() 
{
    Console.Write("Input number of rows: "); 
    int rows = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input the min possible value: "); 
    int maxValue = Convert.ToInt32(Console.ReadLine()); 

    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2Darray(int[,] array) 
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortMassive(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int k = 0; k < array.GetLength(1); k++)
        {
            {
                for (int j = 0; j < array.GetLength(0) - 1; j++)
                {
                    if (array[i,j] < array[i,j + 1])
                        {
                            int temp = array[i,j];
                            array[i,j] = array[i,j + 1];
                            array[i,j + 1] = temp;
                        }
                }
            
            }
        }
    Console.WriteLine();
}

int[,] newArray = RandomArray2d(); 
Show2Darray(newArray); 
SortMassive(newArray); 
Show2Darray(newArray);
*/

//////Task56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] CreateRandome2dArray()
{
    Console.Write("Input number of rows: "); 
    int rows = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input the min possible value: "); 
    int maxValue = Convert.ToInt32(Console.ReadLine()); 
    int[,] newArray = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
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
int SumLineElements(int[,] array, int i) 
{
    int sumLine = 0;
    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    Console.WriteLine($"The sum of the numbers in line {i} is:  {sumLine};");
      
    return sumLine;
}
void MinSumElements(int[,] array)        
{
    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    Console.WriteLine($"\n{minSumLine} - is the line with the smallest sum of elements ({sumLine})  ");
}
int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
MinSumElements(newArray);
*/

//-----Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*int [,] CreateRandome2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимально возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимально возможное значение: ");
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
int[,] MultiplicationMatrix(int[,] array, int[,] array1)
{
    int rows = array1.GetLength(0);
    int colums = array.GetLength(1);
    int[,] newArray = new int[rows, colums];
    if(rows != colums) Console.WriteLine("Данные матрицы умножать нельзя!");
    else
        
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                int sum = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    sum += array[i,k] * array1[k,j];
                }
                newArray[i,j] = sum;
            }
        }
        return newArray;
}
Console.WriteLine("Заполнение первой матрицы: ");
int[,] newArray1 = CreateRandome2dArray();
Console.WriteLine("\nЗаполнение второй матрицы: ");
int[,] newArray2 = CreateRandome2dArray();
Show2dArray(newArray1);
Show2dArray(newArray2);
Console.WriteLine("\nРезультат умножения двух матриц: ");
int[,] newArray3 = MultiplicationMatrix(newArray1, newArray2);
Show2dArray(newArray3);*/


//-----Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int [,,] CreateRandome3dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество колонок: ");
    int colums1 = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, colums, colums1];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            for(int k = 0; k < colums1; k++)
                newArray[i,j,k] = GenerateUniqueNumber();
    
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] - {array[i,j,k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

HashSet<int> numbers = new HashSet<int>(); //---Создание динамической неупорядоченной коллекции
Random rand = new Random();

int GenerateUniqueNumber()
{
    while (true)
    {
        var n = rand.Next(10, 100); //---Генерируем случайный уникальный номер из заданного диапазона
        if (!numbers.Contains(n))  //---Проверяем на неповторяемость
        {
            numbers.Add(n); //--Добавляем в коллецию
            return n;
        }
    }
}

int[,,] newArray = CreateRandome3dArray();
Show3dArray(newArray);
*/

////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////SEMINAR8//////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////
//Task 1//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
int[,] CreateRandom2Array()
{
    Console.WriteLine("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
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
void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
}
int[,] myArray = CreateRandom2Array();
ShowArray2(myArray);
ChangeRows(myArray, 0, 8);
ShowArray2(myArray);
*/

//Task 2//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя. Главная диагональ, меняем местами итые и житые. На вход массив, метод может быть войдовским. Проверить, квадратный массив или нет? Сначала проверить. 
/*
int[,] CreateRandom2Array()
{
    Console.WriteLine("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
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
    Console.WriteLine();
}
void ReverseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}
int[,] array = CreateRandom2Array();
ShowArray2(array);
ReverseArray(array);
ShowArray2(array);
*/

//Task 3// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент. Найти индекс минимального элемента. Выделить новый массив и перезаписать туда этот массив без строк. Или заполнить в строку или столбец нули. Истино минимальный - первый. 
/*
int[,] CreateRandom2Array()
{
    Console.WriteLine("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
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
void DeleteArray(int[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < array[iMin, jMin])
                {
                    iMin = i;
                    jMin = j;
                } 
        }
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if((i == iMin) || (j == jMin))
                {
                    array[i, j] = 0;
                }        
        } 
}
int[,] array = CreateRandom2Array();
ShowArray2(array);
DeleteArray(array);
ShowArray2(array);
*/

// Task 4  // Написать программу поэлементного копирования массива. Новый массив с теме же элементами, что и старый. 
/*
int[,] CreateRandom2Array()
{
    Console.WriteLine("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

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

int[,] CreateCopyFirstArray(int[,] array)
{
     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
     for(int i = 0; i < array.GetLength(0); i++)
         for(int j = 0; j < array.GetLength(1); j++)
         {
             newArray[i, j] = array[i,j];
         }
     return newArray;
}

int[,] array = CreateRandom2Array();
ShowArray2(array);
Console.WriteLine();
int[,] newArray = CreateCopyFirstArray(array);
ShowArray2(newArray);
*/