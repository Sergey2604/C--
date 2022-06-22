/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

int[,] CreateArray1(int a, int b)
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
int[,] CreateArray2(int a, int b)
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
    Console.WriteLine();
}
int[,] MultiMatrix(int[,] array1, int[,] array2, int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return array;
}
int[,] arr1 = CreateArray1(3, 3);
int[,] arr2 = CreateArray2(3, 3);
PrintArray(arr1);
PrintArray(arr2);
int[,] newArr = MultiMatrix(arr1, arr2, 3, 3);
PrintArray(newArr);