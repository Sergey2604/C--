/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
*/

/// Рандомный двумерный массив
int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayRandomValue.Next(10);
        }
    }
    return array;
}


/// Метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}


int[,] array = GetArray(3, 3);
PrintArray(array);


/// Возведение  значений массива в квадрат
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j % 2 == 0 && i % 2 == 0)
        {
            array[i, j] *= array[i, j];
        }
    }
}

Console.WriteLine("Новый массив");
PrintArray(array);