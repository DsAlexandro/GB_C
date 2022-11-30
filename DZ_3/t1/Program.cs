/*Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом. Без использования строк*/
//var 2 без строк

void Palindrom(int number)
{
    if (number > 9999 && number <= 99999)
    {
        int num1  = number / 10000;
        int num2  = number / 1000 % 10;
        int num3  = number % 100 / 10;
        int num4  = number % 10;
        if(num1 == num4 && num2 == num3)
        {
            Console.WriteLine("Число " + number + " является палиндромом!");
        }
        else Console.WriteLine("Число " + number + " не является палиндромом!");
    }
    else Console.WriteLine("Введите пятизначное число !!! ");
}
Console.Write("Введите пятизначное число = ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);