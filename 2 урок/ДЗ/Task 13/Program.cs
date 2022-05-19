/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
Примеры:
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

System.Console.Write("Введите число: ");
var number = Console.ReadLine();

if (number.Length >= 3)
{
    System.Console.WriteLine(number[2]);
}
else System.Console.WriteLine("третьей цифры нет");