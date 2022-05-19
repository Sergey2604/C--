/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
Примеры:
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число, обозначающее день недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    System.Console.WriteLine("ДА!");
}
else
{
    System.Console.WriteLine("Нет");
}