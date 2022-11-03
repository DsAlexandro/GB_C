//Задача №4
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 2;
while (M <= N)
{
    Console.Write(M + ",");
    M += 2;
}