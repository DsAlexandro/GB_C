//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}



void PrintArray(int[] intArray)
{
    
    for (int i = 0; i < intArray.Length; i++)
    {
        System.Console.Write($"[{intArray[i]}]");
    }
}


int Element(int[] intArray)
{
    int sum = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if(intArray[i] % 2 == 0) sum ++;
        
    }
    System.Console.WriteLine($"{sum}");
    return sum;
}



System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int[] Array = CreateArray(length,min,max);
PrintArray(Array);
System.Console.WriteLine();
System.Console.Write("Колличество четных элементов равняется: ");
Element(Array);