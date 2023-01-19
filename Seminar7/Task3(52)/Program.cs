// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray()
{
    Console.WriteLine("Введите количество строк  ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int j = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[i, j];

    return matrix;
}

int[,] array2D = CreateArray();


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Random.Shared.Next(1, 10);
            Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine();
    }
}

FillArray(array2D);

Console.WriteLine();

double average = 0;
for (int j = 0; j < array2D.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        sum = (sum + (array2D[i, j]));
    }
    average = sum / array2D.GetLength(0);
    Console.Write(average + "; ");
}