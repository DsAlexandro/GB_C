// Задача 3 Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать строки для расчета.

void num_3(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
    }
    else
    {
        while(number > 1000)
        {
            number = number / 10;
        }
        int num_3 = number % 10;
        Console.WriteLine("Третья цифра = " + num_3);
}
}
Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());
num_3(number);
