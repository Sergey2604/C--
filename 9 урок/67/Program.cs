/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
 */
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int NaturalNumbers(int num)
{
    sum = sum + (num % 10);
    if (num == 0) return sum;
    NaturalNumbers(num / 10);

    return sum;
}
NaturalNumbers(n);
Console.Write($"{sum} ");