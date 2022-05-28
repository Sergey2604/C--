/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве. */

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sum++;
    }
}
Console.WriteLine(string.Join(' ', array));
Console.WriteLine(sum);