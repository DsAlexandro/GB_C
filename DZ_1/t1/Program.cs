//Задача №1
Console.WriteLine("Дано два числа ");
int number_1 = new Random().Next(1,20);
int number_2 = new Random().Next(1,20);
Console.WriteLine(number_1);
Console.WriteLine(number_2);


if(number_1 > number_2)
{
    Console.WriteLine("Максимальное число - " + number_1);
    Console.WriteLine("Минимальное число - " + number_2);
}
else
{
    Console.WriteLine("Максимальное число - " + number_2);
    Console.WriteLine("Минимальное число - " + number_1);
}




