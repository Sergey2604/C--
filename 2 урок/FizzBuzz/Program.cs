int i = 1;
int max = 100;
while (i <= max)
{
    if (i % 3 == 0 && i % 5 == 0) System.Console.WriteLine("FizzBuzz");
    else if (i % 5 == 0) System.Console.WriteLine("Buzz");
    else if (i % 3 == 0) System.Console.WriteLine("Fizz");
    else System.Console.WriteLine(i);
    i++;
};
Console.ReadKey();