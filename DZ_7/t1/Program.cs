//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


double GetRandomeNumber(double min, double max)
{
    return new Random().NextDouble()*(max-min) + min;
}


double[,] CreateMatrix(int l,int h, double min, double max)
{
    double[,] matrix = new double[l,h];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < h; j++)
        {
            matrix[i,j] = GetRandomeNumber(min,max);
        }
    }
    return matrix;
}

void PrintArray(double[,] array)
{
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;        // количество столбцов
 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"[{array[i, j]:f1}] ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк матрицы - ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы - ");
int hight = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение - ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение - ");
double max = Convert.ToDouble(Console.ReadLine());
double[,] array = CreateMatrix(length,hight,min,max);
PrintArray(array);


