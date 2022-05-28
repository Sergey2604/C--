/* Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76
 */

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
int arrayMax = array[0];
int arrayMin = array[0];
int FindMax()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > arrayMax)
        {
            arrayMax = array[i];
        }
    }
    return arrayMax;
}
int FindMin()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < arrayMin)
        {
            arrayMin = array[i];
        }
    }
    return arrayMin;
}
FindMax();
FindMin();
int result = arrayMax - arrayMin;


Console.WriteLine($"Array - {string.Join(' ', array)}");

System.Console.WriteLine($"Maximum - {arrayMax}");
System.Console.WriteLine($"Minimum - {arrayMin}");
System.Console.WriteLine($"Result - {result}");
