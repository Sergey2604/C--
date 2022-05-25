/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
 */
int[] array = [0];
int count = 0;
int length = 8;
for (int i = 0; i <= length; i++)
{
    array[i] = new Random().Next(0, 1);
}
System.Console.WriteLine(array);