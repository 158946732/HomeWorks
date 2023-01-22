// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber()
{
    Console.WriteLine("Введите число N (больше единицы) ");
    return Convert.ToInt32(Console.ReadLine());
}

int endNumber = GetNumber();

void ShowInt(int number)
{
    if (number <= 0) return;
    Console.Write($"{number} ");
    ShowInt(number - 1);
}
ShowInt(endNumber);