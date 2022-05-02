Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
int i = 1;

while (i < num1)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
    i++;
}
Console.ReadKey();