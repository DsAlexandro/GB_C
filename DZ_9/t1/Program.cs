/*Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/
int Promt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}
void Number (int n, int m)
{
    if (n > m)
    {
        Console.WriteLine(); 
        Console.WriteLine($"Конец!!!"); 
        return ;        
    } 
        
    if(n%2==0) Console.Write($"[{n}] "); 
    Number(n+1,m);
    
}

void Main()
{
    int N = Promt("Введите N = ");
    int M = Promt("Введите M = ");
    Number(N,M);
}


Main();
