// Задача 4 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

void data(int number)
{
    
    if(number < 8)
    {
        if(number == 6 || number == 7)
        {
            Console.WriteLine("Чтож сегодня выходной и можно сходить в парк");
        }
        else
        {
            Console.WriteLine("Сегодня рабочий день, стоит ударно поработать"); 
        }
    }
    else Console.WriteLine("Введите число от 1 до 7!!!!");
}
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
data(number);

