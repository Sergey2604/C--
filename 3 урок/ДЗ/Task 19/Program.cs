/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

System.Console.Write("Введите пятизначное число: ");
var palindrom = Console.ReadLine();
int i = 1;

if (palindrom[i - 1] == palindrom[palindrom.Length - i] && palindrom[i] == palindrom[palindrom.Length - (i + 1)])
{
    System.Console.WriteLine("Вы ввели палиндром");
}
else System.Console.WriteLine("Вы ввели обычное число");