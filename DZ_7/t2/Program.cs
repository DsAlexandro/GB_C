/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int PromtInt(string msg)
{
    Console.Write(msg);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}


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


void FindNumber(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;        // количество столбцов
    int number = PromtInt("Введите значение элемента - ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(array[i,j] == number) 
            {
                Console.WriteLine($"Значение элемента [{number}] находится на позиции [{i},{j}] ");
                
            }
            
            
        }
        
    }
      
    

}

void FindPos(int[,] array, int i, int j)
{
    if(i < 0 || j < 0) Console.Write("Введите положительные значения индексов");
    else
    {
        if(i < array.GetLength(0) && j < array.GetLength(1)) 
        {
            Console.Write($"Значение стоящие на индексе ({i},{j}) равняется - {array[i,j]}");
        }
        else  Console.Write("Такого элемента нет!");
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
FindNumber(array);
Console.Write("Введите значение индекса i - ");
int posi = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение индекса j - ");
int posj = Convert.ToInt32(Console.ReadLine());
FindPos(array, posi, posj);








