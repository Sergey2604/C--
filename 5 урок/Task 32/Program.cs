/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */

int[] numsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < numsArr.Length; i++)
{
    numsArr[i] *= -1;
}
System.Console.WriteLine(string.Join(' '), numsArr);