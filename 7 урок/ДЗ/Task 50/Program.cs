/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] CreateArray(int a, int b)
{
    Console.Write("Введите количество строк: ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    b = int.Parse(Console.ReadLine());
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
void FindElement(int[,] array)
{
    Console.Write("Введите порядковый номер строки искомого элемента : ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите порядковый номер столбца искомого элемента : ");
    int b = int.Parse(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a == i + 1 && b == j + 1)
            {
                System.Console.WriteLine(array[i, j]);
            }

        }
    }
    if (a > array.GetLength(0) || b > array.GetLength(1))
    {
        System.Console.WriteLine("Такого элемента в массиве нет");
    }
    return;
}
int[,] arr = CreateArray(3, 5);
PrintArray(arr);
FindElement(arr);