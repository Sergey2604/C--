/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
Примеры:
456-> 5
782-> 8
918-> 1 */

int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(Convert.ToString(number)[1]);