System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int count = 0;

while (num != 0)
{
    num = num / 10;
    count++;
}
System.Console.WriteLine(count);