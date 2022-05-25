/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
 */

System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];

var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(-9, 10);
    System.Console.Write(nums[i] + ", ");
}
int[] res = new int[size];
System.Console.WriteLine();
for (int i = 0; i < nums.Length / 2 + 1; i++)
{
    res[i] = nums[i] * nums.Last() - i;
    System.Console.Write(res[i] + ", ");
}
