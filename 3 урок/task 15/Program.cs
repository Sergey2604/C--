var day = Convert.ToInt32(Console.ReadLine());
string[] isWeekend = { "нет", "нет", "нет", "нет", "нет", "да", "да" };
if (day > 0 && day < 8)
{
    Console.WriteLine(isWeekend[day - 1]);
}
