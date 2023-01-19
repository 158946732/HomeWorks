// Задайте двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// 5  2  6  7
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

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

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}

FillArray(array2D);

int MinSumLine(int[,] array, int i) // + int i
{
    int sumRow = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow = sumRow + array[i, j];
    }

    return sumRow;
}
int minSumLine = 0;
int rowSum = MinSumLine(array2D, 0);

for (int i = 1; i < array2D.GetLength(0); i++)
{
    int tempSumLine = MinSumLine(array2D, i);
    if (rowSum >= tempSumLine)
    {
        rowSum = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minSumLine+1}");

