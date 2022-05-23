// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("x > 0 && y > 0");
}
else if (number == 2)
{
    System.Console.WriteLine("x < 0 && y > 0");
}
else if (number == 3)
{
    System.Console.WriteLine("x < 0 && y < 0");
}
else if (number == 4)
{
    System.Console.WriteLine("x > 0 && y < 0");
}
else System.Console.WriteLine("Вы ввели некорректные значения");