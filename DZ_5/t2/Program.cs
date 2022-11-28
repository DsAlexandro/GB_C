//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


int[] CreateArray(int length, int min, int max)
{
    
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;

}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" [{array[i]}] ");
    }
    
}


int Sum(int[] intArray)
{
    int sum = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if(i % 2 == 1) sum +=intArray[i];
        
    }
    System.Console.WriteLine($"{sum}");
    return sum;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int min = -9;
int max = 9;
int[] Array = CreateArray(length,min,max);
PrintArray(Array);
System.Console.WriteLine();
System.Console.Write("Сумма на нечётных позициях равна = ");
Sum(Array);
