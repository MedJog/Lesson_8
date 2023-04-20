﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] Array = new int[5,5];
FillArray(Array);
PrintArray(Array);
SortRowsArrayMaxMin(Array);
Console.WriteLine();
PrintArray(Array);

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
void SortRowsArrayMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j <= array.GetLength(1) - 2; j++)
            {
                for (int J = j + 1; J <= array.GetLength(1) - 1; J++)
                    {
                        if (array[i,j] < array[i,J])
                        {
                        int basket = array[i,j];
                        array[i,j] = array[i,J];
                        array[i,J] = basket;
                        }
                    }
            }
    }
}


