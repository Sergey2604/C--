/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

System.Console.Write("Введите координаты точки 1:");
double x1 = int.Parse(Console.ReadLine());
double y1 = int.Parse(Console.ReadLine());
double z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки 2:");
double x2 = int.Parse(Console.ReadLine());
double y2 = int.Parse(Console.ReadLine());
double z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
System.Console.WriteLine(result);