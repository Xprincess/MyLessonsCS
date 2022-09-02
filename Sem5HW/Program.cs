//Seminar 5 (Classroom tasks)
// //Create random array

// int[] /*квадратные скобки указывают , что это массив*/ CreateRandomArray(int size, int minValue, int maxValue);/*пределы для генерации, макс и мин значения*/
// //на этой стадии массив сгенерировался
// {
//     int[] newArray = new int[size];/*выделили память под массив*/

//     for(int i = 0;/*объявляем индекс*//*условия существования цикла, идем по циклу до того, когда кончится массив*/ i < size; i++)
//         new[i] = new Random().Next(minValue, maxValue + 1);

//     return newArray
// }

//ShowArray(CreateRandomArray(25,0,9));*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
         {
            Console.Write(array[i] + " ");
         } 
         Console.WriteLine();
        

}
ShowArray(CreateRandomArray(10, 5 ,6));

*/
///////////////////////////////////////////////////////////////////////////////////////////////////
//HW

// //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
/*
internal class Program
{
    private static void Main(string[] args)
    {
        int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = new Random().Next(minValue, maxValue + 1);
            }
            return newArray;
        }


        void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        ShowArray(CreateRandomArray(10, 100, 999));

        int evenNumberCount(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] % 2 == 0) count++;
                
            }
            return count;
        }

        Console.WriteLine("Input the size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the min possible value of array: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the max possible value of array: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[] myArray = CreateRandomArray(size, min, max);
        ShowArray(myArray);

        int count = evenNumberCount(myArray);

        Console.WriteLine($"The amount of even numbers is {count}");
    }
}

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
         {
            Console.Write(array[i] + " ");
         } 
         Console.WriteLine();
}       

int FindSumOddPosition(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
        sum+= array[i];
    return sum;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int sumNumbersArray = FindSumOddPosition(myArray);
Console.WriteLine("The sum of elements at odd positions in the array: " + sumNumbersArray);
*/


// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double [] newArray = new double[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(); //Запишем случайное вещественное число (1 + 0,1)
    return newArray;
}

void ShowArray(double[] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write($"[{array[i]}] ");
    Console.WriteLine();    
}

double FindDifferenceMaxMinValue(double[] array) //Метод вычисления разницы между максимальным и минимальным элементами массива
{
    double minValue = array[0];
    double maxValue = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(minValue > array[i]) minValue = array[i];
        if(maxValue < array[i]) maxValue = array[i];
    }
    double result = maxValue - minValue;
    return result;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

double diffMaxMin = FindDifferenceMaxMinValue(myArray);
Console.WriteLine("The difference between the maximum and minimum array elements: " + diffMaxMin);


