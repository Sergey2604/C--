/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
 */
System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int GetComNumbers(int num)
{
    int com = 1;

    for (int i = 1; i <= number; i++)
    {
        com = com * i;
    }
    return com;
}
System.Console.WriteLine(GetComNumbers(number));
