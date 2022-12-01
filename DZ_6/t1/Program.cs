//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int sum = 0;
while(true)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Для продолжение ввода нажмите Enter, "
                    +"или введите stop для остановки ввода: ");
    string stop = Console.ReadLine();
    if(number>0) sum +=1;
    if(stop == "stop") break;
       
}
Console.Write($"Кол-во положительнильных чисел: {sum}");



