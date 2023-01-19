// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет

int[,] CreateArray()
{
    Console.WriteLine("Введите количество строк  ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int j = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[i, j];

    return matrix;
}

int[,] matrix = CreateArray();

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

FillArray(matrix);

int GetNumber()
{
    Console.Write("Введите число от 0 до 9: ");
    int number = int.Parse(Console.ReadLine());

    if (number > 9 || number < 1)
    {
        Console.Write("такого числа в массиве нет");
    }
    else Console.WriteLine(number); // убрать из вывода
    return number;
}

// изобретение колеса:
void FindNumberPosition (int[,] arr, int numb)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == numb)
            {
            Console.WriteLine($"позиция числа {numb} в массиве = {i},{j}");
            }
        }
    }
}

int findNumber = GetNumber();
FindNumberPosition (matrix, findNumber);
