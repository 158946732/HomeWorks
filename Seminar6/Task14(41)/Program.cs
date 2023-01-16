// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 // 1, -7, 567, 89, 223-> 4

int GetCountByUser()
{
    Console.Write("Введите количество чисел: ");
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetCountByUser();
Console.WriteLine(m);

Console.WriteLine("Введите любые числа: ");

int count = 0;

for (int i = 0; i < m; i++)
{
    int numbers = Convert.ToInt32(Console.ReadLine());
    if (numbers > 0)
    {
        count++;
    }
}

Console.WriteLine($"Чисел больше нуля: {count}");


