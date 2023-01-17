// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray()
{
    Console.WriteLine("Введите количество строк  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = new double[rows,columns];
    
    return matrix;
}

void FillMatrix(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) /10;
            Console.Write($"{matr[i, j],6}");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateArray();
FillMatrix(matrix);