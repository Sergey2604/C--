/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
 */
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());
void NaturalNumbers(int a, int b)
{
    if (a > b)
    {
        int num = a;
        if (num == b) return;
        NaturalNumbers(num - 1, b);
        System.Console.Write($"{num} ");
    }
    else if (b > a)
    {
        int num = b;
        if (num == a) return;
        NaturalNumbers(a, num - 1);
        System.Console.Write($"{num} ");
    }
}
NaturalNumbers(m, n);