// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

    Console.WriteLine("Введите числo M ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите числo N ");
    int n = Convert.ToInt32(Console.ReadLine());


int SumNumbers(int a, int b)
{
    if (a == 0) return (b * (b + 1)) / 2;  
    else if (b == 0) return (a * (a + 1)) / 2; 
    else if (b == a) return b;
    if (a < b)
    {
        return b + SumNumbers(a, b - 1);
    }
    else return b + SumNumbers(a, b + 1);
}
int sum = SumNumbers(n, m);
Console.WriteLine($"Сумма натуральных элементов в промежутке чисел -> {sum}");