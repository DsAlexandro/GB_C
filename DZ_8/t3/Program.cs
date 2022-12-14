/*Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

int Promt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int[,] CreateMatrix(int length,int hight, int min, int max)
{
    int[,] matrix = new int[length,hight];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < hight; j++)
        {
            matrix[i,j] = new Random().Next(min,max+1);
        }
    }
    return matrix;
}

void PrintArray(int[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrix1,int[,] matrix2)
{
    int[,] matrixMultiplication= new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < matrixMultiplication.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMultiplication.GetLength(1); j++)
        {
            matrixMultiplication [i,j] = 0;
            for (int l = 0; l < matrix1.GetLength(1); l++)
            {
                matrixMultiplication[i,j] += matrix1[i,l] * matrix2[l,j];
            }
            Console.Write($"[{matrixMultiplication [i, j]}] ");
        }
        Console.WriteLine();
        
        
    }
    return matrixMultiplication;


}

void Main()
{
    int length = Promt("Введите количество строк матрицы - ");
    int hight = Promt("Введите количество столбцов матрицы - ");
    int min = Promt("Введите минимальное значение - ");
    int max = Promt("Введите максимальное значение - ");
    int[,] matrix1 = CreateMatrix(length,hight,min,max);
    PrintArray(matrix1);
    Console.WriteLine();
    int[,] matrix2 = CreateMatrix(length,hight,min,max);
    PrintArray(matrix2);
    Console.WriteLine();
    MatrixMultiplication(matrix1,matrix2);
}
Main();