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
