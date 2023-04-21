/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] Array = new int[4,4];


HelixArray(Array);
PrintArray(Array);
Console.WriteLine();
PrintArray(HelixArray2(Array, 4, 4));

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


int[,] HelixArray(int[,]array)
{   
    int i = 0; 
    int j = 0; 
    int M = Array.GetLength(0);
    int N = Array.GetLength(1); 
    int element = 0;
    for (j = 0; j < N; j++)
        {
            Array[i,j] = element + 1;
            element++; 
        }
    for (i = i+1; i < M; i++)
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
    M = M - 1;
    N = N - 1;
    for (j = j+1; j < N; j++)
        {
            Array[i+1,j] = element + 1;
            element++; 
        }
    for (i = i+2; i < M; i++)
        {
        Array[i,j-1] = element + 1;
        element++; 
        }
    for (j = j-1; j > 1; j--)
        {
        Array[i-1,j-1] = element + 1;
        element++; 
        }
return array;
}


int[,] HelixArray2(int[,]array, int Rows, int Columns)
{  
int minRow = 0; 
int maxRow = Rows - 1; 
int minCol = 0;
int maxCol = Columns - 1;
int Element = 0;
int maxElement = Rows * Columns;
while (Element < maxElement)
{
    for (int i = minCol; i <= maxCol; i++) // движение вправо
        {
        Array[minRow,i] = Element + 1;
        Element++; 
        }
    minRow = minRow + 1;    
    for (int i = minRow; i <= maxRow; i++) //движение вниз
        {
        Array[i,maxCol] = Element + 1;
        Element++; 
        }
    maxCol = maxCol - 1;
    for (int i = maxCol; i >= minCol; i--) // движение влево
        {
        Array[maxRow,i] = Element + 1;
        Element++; 
        }
    maxRow = maxRow - 1;
    for (int i = maxRow; i >= minRow; i--) // движение вверх
        {
        Array[i,minCol] = Element + 1;
        Element++; 
        }
    minCol = minCol + 1; // уменьшение границы
} 
return array;
}
