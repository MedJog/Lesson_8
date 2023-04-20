/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] Array = new int[4,4];

FillArray(Array);
PrintArray(Array);
Console.WriteLine();
HelixArray(Array, 0, 0);
PrintArray(Array);
void FillArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = 0;
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


void HelixArray(int[,]array, int i, int j)
{
    int element = 0;
    for (j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = element + 1;
            element++; 
        }

for (i = i+1; i < Array.GetLength(0); i++)
    {
        Array[i,j-1] = element + 1;
        element++; 
    }
for (j = j-1; j > 0; j--)
    {
        Array[i-1,j-1] = element + 1;
        element++; 
    }
for (i = i - 2; i > 0; i--)
    {
        Array[i,j] = element + 1;
        element++; 
    }

}
