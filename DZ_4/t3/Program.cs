/*Задача 3: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] CreateArray(int[] Array) 

{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива:  ");
        Array[i] = int.Parse(Console.ReadLine());
    }
    return Array;

}


int[] PrintArray(int[] Array)
{
    
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]},");
        
    }
    Console.Write("]");
    return Array;
}

Console.Write("Введите кол-во элементов в массиве:  ");
int elements = int.Parse(Console.ReadLine());
if(elements > 0 )
{
    int[] Array = new int[elements];
    CreateArray(Array);
    PrintArray(Array);
}
else 
{
    Console.WriteLine("Введите положительное, целое число");
}


