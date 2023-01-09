// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 / 78 -> третьей цифры нет / 32679 -> 6

int N = 32679;
string number3 = N.ToString();

if (number3.Length > 2)
{
    Console.WriteLine(number3[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}