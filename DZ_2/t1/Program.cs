//Задача 1Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа. Не использовать строки для расчета.
void Num_2(int number)
{
    if(number/100 > 9 || number/10 < 9 )
    {
        Console.WriteLine("Просили же трёхзначное число!!!!");
        
    }
    else
    {
        int num_2 = number / 10 % 10;
        Console.WriteLine("Вторая цифра - " + num_2);
        
    }
}
Console.Write("Введите трёхзначное число - ");
int number = int.Parse(Console.ReadLine());
Num_2(number);

