/* При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
Ввожу => 12
1 2 2 3 3 3 4 4 4 4 5 5*/


int recurs (int n)
{
    int sum = 0;
    int j = 0;

    if(n==1) 
    {
        Console.Write(1);
        return 0;
    } 
    else
    {
        for (int i = 1; sum < n; i++)
        {
            sum += i;
            j = i;
        }
        Console.Write(recurs(--n) + 0 +j);
        return 0;
    }

    
}
int n = recurs(20);
