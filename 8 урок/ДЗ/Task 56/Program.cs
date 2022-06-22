/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

int[,] CreateArray(int a, int b)
{
    Random rndArray = new Random();
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndArray.Next(10);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FindSum(int[,] array)
{
    int min = int.MaxValue;
    int minStr = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {

            sum = sum + array[i, j];
        }
        if (min > sum)
        {
            min = sum;
            minStr = i;
        }
        System.Console.WriteLine(sum + ", " + min);
    }
    System.Console.WriteLine($"Строка с минимальным значением {min} - {minStr + 1}");
    return;
}
int[,] arr = CreateArray(3, 3);
PrintArray(arr);
FindSum(arr);