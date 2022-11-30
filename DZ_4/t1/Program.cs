/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Degree(int a, int b)
{
    int j = 1;
    for(int i = 0; i < b; i++)
    {
        j = j*a;
    }
    Console.WriteLine($"Число А, возведенная в степень В, равняется {j}");   
    return j;
}
Console.Write("Введите число А = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В = ");
int B = Convert.ToInt32(Console.ReadLine());
Degree(A,B);
