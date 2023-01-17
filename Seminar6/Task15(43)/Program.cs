// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double b1, double k1, double b2, double k2) GetPoints () // использование кортежа
{
    Console.Write("Введите значениe k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите значениe b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите значениe k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите значениe b2: ");
    double b2 = double.Parse(Console.ReadLine());
    return (k1, b1, k2, b2);
}

(double x, double y) GetPointCross (double k1, double b1, double k2, double b2) 
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    if (k1 - k2 == 0)
    {
        Console.WriteLine("Прямые не пересекаются!");
    }
    return (x, y);
}

void PrintСoordinates (double x, double y)
{
    Console.WriteLine($"Координаты точки пересечения двух прямых: {x}, {y}");
}

var pointsOfLines = GetPoints();
double k1 = (pointsOfLines.Item1);
double b1 = (pointsOfLines.Item2);
double k2 = (pointsOfLines.Item3);
double b2 = (pointsOfLines.Item4);
(double x, double y) = GetPointCross(k1, b1, k2, b2);
PrintСoordinates(x, y);






