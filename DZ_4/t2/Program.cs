/*Задача 2: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int sum (int number)
{
    int summa = 0;// сумма цифр
    int i = 0; // переменная для хранения нового числа
    while (number >= 1)
    {
        
        i = number % 10;
        number = number / 10;
        summa = summa + i;
        
    }
    Console.WriteLine($"Сумма цифр равняется {summa}");
    return summa;
}
Console.Write("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    sum(number);
}
else 
{
    Console.WriteLine("Введите положительное, целое число");
}

