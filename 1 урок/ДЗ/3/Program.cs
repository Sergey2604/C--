Console.Write("Введите число: ");
double num1 = double.Parse(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine("Вы ввели четное число");
}
else
{
    Console.WriteLine("Вы ввели нечетное число");
}