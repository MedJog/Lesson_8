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
//PrintArray(Sum);



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

void SumElementsRowsArray(int[,]array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
        {  
            //int[] Sum = new int[4];
            //for (int index = 0; index < 4; index++)
            //{
                    int sum = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                    sum = sum + array[i,j];
                    }
                    Console.WriteLine(sum);
           // Sum[index] = sum;
           // Console.Write($"**{Sum[index]}**");
           // }
        }
}
