/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. 
 */

int[] Array(int minValue, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minValue;
        minValue++;
    }
    return array;
}

int[,,] GetTripleArray(int a, int b, int c)
{
    int arrayRandomIndex = 1;
    int[] oneArray = Array(-100, 199);///Создание одномерного массива двузначных чисел:
    int[,,] array = new int[a, b, c];
    Random randomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                arrayRandomIndex = randomValue.Next(109, 198);///Положиетльные двузначные числа:
                if (oneArray[arrayRandomIndex] == 0)
                {
                    arrayRandomIndex = randomValue.Next(10, 89);///Отрицательные двузначные числа
                }
                if (array[i, j, k] == 0)
                {
                    array[i, j, k] = oneArray[arrayRandomIndex];///Значение рандомного индекса одномерного массива присваивается трёхмерному:
                    oneArray[arrayRandomIndex] = 0;///Обнуление значения индекса в одномерном массиве:
                    k = 0;
                    j = 0;
                    i = 0;
                }
            }
        }
    }
    return array;
}

/// Метод печати массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("{0,3}", array[i, j, k]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

///Метод построчной печати массива с добавлением индекса элемента:
void PrintIndexedArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"\n{i + 1} мерный массив:");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine("{0,3}", $"Индекс |{i},{j},{k}|  =  ({array[i, j, k]})");
            }
        }
    }
}

int[,,] array = GetTripleArray(3, 3, 6);
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

Console.WriteLine("Построчная печать массива с добавлением индекса элемента:");
PrintIndexedArray(array);