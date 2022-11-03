/*Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом. Без использования строк*/


static bool Palindrom(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - i - 1])
        {
           Console.WriteLine("NO!");     
           return false;
        }
    }
    Console.WriteLine("YES!");
    return true;
}
Console.Write("Введите пятизначное число: ");
string s = Console.ReadLine();
Palindrom(s);
