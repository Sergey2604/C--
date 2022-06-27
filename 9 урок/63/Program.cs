
int n = int.Parse(Console.ReadLine());
void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    System.Console.Write($"{num} ");
}
NaturalNumbers(n);