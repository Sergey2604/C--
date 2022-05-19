int num = new Random().Next(10, 100);
System.Console.WriteLine(num);
int maxNum = MaxNumber(num);
System.Console.WriteLine(maxNum);
int MaxNumber(int number)
{
    int num1 = number / 10;
    int num2 = number % 10;
    return num1 > num2 ? num1 : num2;
}

