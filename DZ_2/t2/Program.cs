﻿//Задача 2  Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа. Не использовать строки для расчета.
Random x = new Random();
int num_1 = x.Next(100,999);
Console.WriteLine("Случайное трёхзначное число = " + num_1);
int num_2 = num_1 / 100 * 10;
int num_3 = num_1 % 10;
int sum_2 = num_2 + num_3;
Console.WriteLine("Число без второй цифры = " + sum_2);