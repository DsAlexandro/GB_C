/*Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Promt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int FunAkkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m!= 0) && (n == 0))
      return FunAkkerman(m - 1, 1);
    else
      return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
}

void Main()
{
    int M = Promt("Введите M = ");
    int N = Promt("Введите N = ");
    Console.WriteLine("Ответ: " + FunAkkerman(M,N));
}

Main();