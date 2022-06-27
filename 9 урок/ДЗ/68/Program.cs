/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите начальное число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите начальное число N: ");
int numberN = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int Ackermann(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Ackermann(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
    return Ackermann(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {Ackermann(numberM, numberN)}");