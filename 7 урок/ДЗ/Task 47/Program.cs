/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] CreateArray(int m, int n)
{
    System.Console.Write("Введите количество строк: ");
    m = int.Parse(Console.ReadLine());
    System.Console.Write("Введите количество столбцов: ");
    n = int.Parse(Console.ReadLine());
    double[,] array = new double[m, n];
    Random rndArray = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndArray.NextDouble() * 10;
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + ", ");
        }
        System.Console.WriteLine();
    }
}
double[,] arr = CreateArray(3, 3);
PrintArray(arr);