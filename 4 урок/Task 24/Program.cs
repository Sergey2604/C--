System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int GetSumNumbers(int num)
{
    int sum = 0;

    for (int i = 0; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}
System.Console.WriteLine(GetSumNumbers(number));