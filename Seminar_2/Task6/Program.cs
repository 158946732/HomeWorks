// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 / 78 -> третьей цифры нет / 32679 -> 6

int number = 32679;
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    System.Console.WriteLine(number % 10);
}