/* Задача 41. Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


System.Console.WriteLine("Введите числа через пробел");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = 0;

int NumHigherZero()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
NumHigherZero();
System.Console.WriteLine(sum);