/*Задача 2
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/

void distanse (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double D = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));

    Console.WriteLine("Расстояние между двумя точками равно = " + D);
}
Console.WriteLine("Введите координаты первой точнки: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точнки: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
distanse(x1,y1,z1,x2,y2,z2);