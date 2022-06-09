/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3. */

int[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int b = int.Parse(Console.ReadLine());
    Random randomArray = new Random();
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomArray.Next(100);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int AverageString(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];

        }
        System.Console.WriteLine($"Среднее арифметическое в {i + 1} строке: {sum / (array.GetLength(0) - 1)}");
    }
    return sum;
}
int[,] arr = CreateArray();
PrintArray(arr);
AverageString(arr);