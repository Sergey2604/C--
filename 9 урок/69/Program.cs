/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
 */

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

int Pow(int a, int pow)
{
    return pow == 0 ? 1 : Pow(a, pow - 1) * a;
}

