/*Задача 3
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/
void cube(int N)
{
    for(int i=1; i<=N; i++)
    {
        int cube = i*i*i;
        Console.Write(cube + ", ");
    }
}
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
cube(N);