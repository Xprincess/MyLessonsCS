//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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