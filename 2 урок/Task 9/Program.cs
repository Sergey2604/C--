int num = new Random().Next(10, 100);
System.Console.WriteLine(num);
int firstDigit = num / 10;
int secondDigit = num % 10;
System.Console.WriteLine(firstDigit);
System.Console.WriteLine(secondDigit);
if (firstDigit > secondDigit)
{
    System.Console.WriteLine(firstDigit);
}
else System.Console.WriteLine(secondDigit);