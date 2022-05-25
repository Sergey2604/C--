/* Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
 */

System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
//int[] nums = new int[size];


int[] numsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(string.Join(' ', numsArr));

int positive = 0;
int negative = 0;

/* var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(-9, 10);
    System.Console.WriteLine(nums[i] + ", ");
} */
/* for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0) positive += nums[i];
    else negative += nums[i];
} */
System.Console.WriteLine($"Сумма положительных элементов массива= {positive}");
System.Console.WriteLine($"Сумма отрицательных элементов массива= {negative}");