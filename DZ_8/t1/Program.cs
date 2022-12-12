/*Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/




int[,] CreateMatrix(int l,int h, int min, int max)
{
    int[,] matrix = new int[l,h];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < h; j++)
        {
            matrix[i,j] = new Random().Next(min,max+1);
        }
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;        // количество столбцов
 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
}

int[,] Descending(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for( int k=0; k < array.GetLength(1) - j -1; k++)
            {
                if (array[i,k]<array[i,k+1])
                    (array[i,k], array[i,k+1]) = (array[i,k+1],array[i,k]);
            }
            
            
        }
        
    }
    return array;
}


Console.Write("Введите количество строк матрицы - ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы - ");
int hight = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение - ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение - ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateMatrix(length,hight,min,max);
PrintArray(array);
Descending(array);
Console.WriteLine();
PrintArray(array); 