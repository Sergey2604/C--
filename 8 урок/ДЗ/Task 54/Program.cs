/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndArray = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndArray.Next(0, 10);
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
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}


///Метод сортировки строк массива
int[,] SortArrayRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                for (int l = k + 1; l < array.GetLength(1); l++)
                {
                    if (array[i, k] < array[i, l])
                    {
                        temp = array[i, l];
                        array[i, l] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

    }
    return array;
}

int[,] arr1 = GetArray(6, 6);
Console.WriteLine("Изначально заданный массив: ");
PrintArray(arr1);
Console.WriteLine();
Console.WriteLine("Элементы массива отсортированы по убыванию: ");
int[,] arr2 = SortArrayRows(arr1);
PrintArray(arr2);