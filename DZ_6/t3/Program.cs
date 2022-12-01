//Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
//Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
//1 2 3
//3 4 5
//3+5=8, 1+2+3=6, 8-6=2

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

int MaxLenght(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows; 
    int sumlenght = 0;
    for (int i = 0; i < rows; i++)
    {
        int max = 0;
        for (int j = 0; j < columns; j++)
        {
            if(array[i,j] > max ) max = array[i,j];
        }
        sumlenght += max;
    }
    System.Console.WriteLine($"Сумма максимальных значений в каждой строке - {sumlenght}");
    return sumlenght;
}

int MinHight(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows; 
    int sumhight = 0;
    for (int i = 0; i < columns; i++)
    {
        int min = array[0,0];
        for (int j = 0; j < rows; j++)
        {
            if(array[j,i] < min ) min = array[j,i];
        }
        sumhight += min;
    }
    System.Console.WriteLine($"Сумма минимальных значений в каждой столбце - {sumhight}");
    return sumhight;
}

int Diff(int[,] array)
{
    int sum = 0;
    sum = MaxLenght(array) - MinHight(array);
    System.Console.Write("Разница между максимальным и минимальным - ");
    System.Console.WriteLine($"{sum}");
    return sum;
}


Console.Write("Введите длину матрицы - ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту матрицы - ");
int hight = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение - ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение - ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateMatrix(length,hight,min,max);
PrintArray(array);
Diff(array);