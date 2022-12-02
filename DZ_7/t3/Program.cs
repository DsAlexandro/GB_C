
/*Задача 3. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/




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

void Average(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;  
    int columns = array.Length / rows;  
    for (int i = 0; i < columns; i++)
    {
        double average = 0;
        for (int j = 0; j < rows; j++)
        {
            average += array[j,i];
        }
        average = average / rows;
        Console.WriteLine($"Среднее арифметическое {i} столбца:{average:f2}");
        
    }
    
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
Average(array);