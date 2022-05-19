Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
    Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");
