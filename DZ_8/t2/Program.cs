/*Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] MinSum(int[] sum)
{
    int min = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if(sum[i] < sum[min]) min = i;
    }
    Console.Write($"Номер строки с наименьшей суммой - {min}");
    return sum;
}

int[] SumRow(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow +=array[i,j];   
        }
        sum[i] = sumRow;
    }
    return MinSum(sum);


}

void Main()
{
    int length = Promt("Введите количество строк матрицы - ");
    int hight = Promt("Введите количество столбцов матрицы - ");
    int min = Promt("Введите минимальное значение - ");
    int max = Promt("Введите максимальное значение - ");
    int[,] array = CreateMatrix(length,hight,min,max);
    PrintArray(array);
    SumRow(array);
}
Main();