/*Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/


int N = Promt("Введите N = ");
int M = Promt("Введите M = ");
int i = N;
Number(N);
int Promt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}
void Number (int n)
{
    if (i==M)
    {
        Console.WriteLine($"Сумма чисел между промежутком M и N равняется {n}"); 
        Console.WriteLine($"Конец!!!"); 
        return ;        
    } 
    i++;
    Number(n+i);
    
}
