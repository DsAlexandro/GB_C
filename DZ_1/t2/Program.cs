//Задача №2
Console.WriteLine("Введите три числа: ");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());
int number_3 = int.Parse(Console.ReadLine());
int max = number_1;
if(max < number_2)
{
   max = number_2 ;
}

if(max < number_3)
{
   max = number_3;
}
Console.WriteLine("Максимальное число - " + max);








