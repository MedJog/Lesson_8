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
Console.WriteLine();
//HelixArray(Array, 1, 1); 
//PrintArray(Array);

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
                Console.Write($"{array[i,j]}   ");
            }
    Console.WriteLine();        
    }
}


int[,] HelixArray(int[,]array, int m, int n)
{   
    int i = m; // индекс строки
    int j = n; // индекс столбца

    int M = Array.GetLength(0); // строки массива
    int N = Array.GetLength(1); // столбцы массива
    int element = 0;
    for (j = n; j < N; j++)
        {
            Array[i,j] = element + 1;
            element++; 
        }
Console.WriteLine($"i = {i}");
Console.WriteLine($"j = {j}");
Console.WriteLine($"элемент {element}");
    for (i = i+1; i < M; i++)
        {
        Array[i,j-1] = element + 1;
        element++; 
        }
Console.WriteLine($"i = {i}");
Console.WriteLine($"j = {j}");
Console.WriteLine($"элемент {element}");
    for (j = j-1; j > 0; j--)
        {
        Array[i-1,j-1] = element + 1;
        element++; 
        }
Console.WriteLine($"i = {i}");
Console.WriteLine($"j = {j}");
Console.WriteLine($"элемент {element}");
    for (i = i - 2; i > 0; i--)
        {
        Array[i,j] = element + 1;
        element++; 
        }
    M = M - 1;
    N = N - 1;
    
Console.WriteLine($"i =  {i}");
Console.WriteLine($"j = {j}");
Console.WriteLine($"элемент {element}");
Console.WriteLine($"M =  {M}");
Console.WriteLine($"N =  {N}");
    for (j = n+1; j < N; j++)
        {
            Array[i+1,j] = element + 1;
            element++; 
        }
Console.WriteLine($"i = {i}");
Console.WriteLine($"j = {j}");
Console.WriteLine($"элемент {element}");
    for (i = i+2; i < M; i++)
        {
        Array[i,j-1] = element + 1;
        element++; 
        }
Console.WriteLine($"i = {i}");
Console.WriteLine($"j = {j}");
Console.WriteLine($"элемент {element}");
    for (j = j-1; j > 1; j--)
        {
        Array[i-1,j-1] = element + 1;
        element++; 
        }
Console.WriteLine($"i = {i}");
Console.WriteLine($"j = {j}");
Console.WriteLine($"элемент {element}");


return array;
}
