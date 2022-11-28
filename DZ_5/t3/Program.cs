//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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


int diff(int[] intArray)
{
    int sum = 0;
    int max = 0;
    int min = intArray[0];
    for (int i = 0; i < intArray.Length; i++)
    {
        if(intArray[i] < min ) min = intArray[i];
        if(intArray[i] > max ) max = intArray[i];
        
    }
    System.Console.WriteLine($"min = {min}");
    System.Console.WriteLine($"max = {max}");
    System.Console.Write("Разница между максимальным и минимальным элементов массива = ");
    sum = max - min;
    System.Console.WriteLine($"{sum}");
    return sum;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 90;
int[] Array = CreateArray(length,min,max);
PrintArray(Array);
System.Console.WriteLine();
diff(Array);
