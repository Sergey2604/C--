System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 1;

while (i <= number)
{
    int x = i * i;
    Console.Write($"{x}, ");
    i++;
}