/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
int count = 1;
double res = 1;

while (count <= num2)
{
    res = num1 * res;
    count++;
}

System.Console.WriteLine(res);