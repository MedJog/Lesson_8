/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] Array = new int[4,6];
FillArray(Array);
PrintArray(Array);
SumElementsRowsArray(Array);
Console.WriteLine();
PrintArr(SumElementsRowsArray(Array));
Console.WriteLine();
IndexRowsMinSum(SumElementsRowsArray(Array));




void FillArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(1,10);
            }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
            }
    Console.WriteLine();        
    }
}

int[] SumElementsRowsArray(int[,]array)
{   int[] Sum = new int[4];
    for (int i = 0; i < array.GetLength(0); i++)
        {  
            {
                    int sum = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                    sum = sum + array[i,j];
                    }
            Sum[i] = sum;
           }
        }
    return Sum;
}
void PrintArr(int[] col) 
{
    int count = col.Length;
    int position = 0;
     while (position < count)
    {
    Console.Write($"{col[position]} ");
    position++;
    }
} 

void IndexRowsMinSum(int[]array)
{
    int i = 0;
    int minSum = array[i];
    int minIndex = i;
    while (i < array.Length)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            minIndex = i;
        }
        i++;
    }
    //Console.WriteLine(minSum);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов {minIndex}");
}