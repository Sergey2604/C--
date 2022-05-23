// See https://aka.ms/new-console-template for more information
Console.Write("Введите координату Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    System.Console.WriteLine("Диапазон ходится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Диапазон ходится во 2 четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Диапазон ходится в 3 четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Диапазон ходится в 4 четверти");
}