/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

int[,] Matrix1 = new int[3,3];
int[,] Matrix2 = new int[3,3];
FillArray(Matrix1);
FillArray(Matrix2);
Console.WriteLine("Первая матрица");
PrintArray(Matrix1);
Console.WriteLine("Вторая матрица");
PrintArray(Matrix2);
MatrixMultiplication(Matrix1, Matrix2);
Console.WriteLine("Результирующая матрица");
PrintArray(MatrixMultiplication(Matrix1, Matrix2));

void FillArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(1,5);
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

int[,] MatrixMultiplication(int[,] matrix1, int[,]matrix2)
{   
    int I = 0;
    int j = 0;
    int[,] MatrixMult = new int[3,3];
    for (int i = 0; i < matrix1.GetLength(0); i++)
        {
        for (int J = 0; J < matrix2.GetLength(1); J++)
            {
            int result = matrix1[i,j] * matrix2[I,J] + matrix1[i,j+1] * matrix2[I+1,J];
            MatrixMult[i,J] = result;
            }

        }
        return MatrixMult;
}    



   
