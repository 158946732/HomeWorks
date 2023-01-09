// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да / 7 -> да / 1 -> нет

Console.Write("Введите номер дня недели ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());
if (DayOfWeek % 7.1 > 5)
{
    System.Console.WriteLine("выходной");
}
else
{
    System.Console.WriteLine("будничный");
}