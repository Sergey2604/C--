/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; 5,5) 

y = y или k1 *x + b1 = k2 * x + b2. Из этого равенства можно найти Х.
x = (b2 - b1) / (k2 - k1);
y = k1*x + b1.
У нас два y. y=y. Отсюда ищем х


Сергей, исходя из того, что y = y, сначала делаем уравнение: k1 *x + b1 = k2 * x + b2. 
потом решаем его, перенеся все буквы на одну сторону уравнения, а числа - в другую.  
результат решения: x = (b2 - b1) / (k2 - k1). это и загоняем в код

*/


Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = int.Parse(Console.ReadLine());
double x;
double y;

void SearchDot()
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}
SearchDot();
System.Console.WriteLine(x + ", " + y);
