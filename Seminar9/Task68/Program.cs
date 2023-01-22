// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное числo M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное числo N ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int a, int b)
{
    if (a == 0)
        return b + 1;
    else if (a > 0 && b == 0)
        return AkkermanFunction(a - 1, 1);
    else return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
}

int result = AkkermanFunction(m, n);
Console.WriteLine($" -> A(m,n) = {result}");