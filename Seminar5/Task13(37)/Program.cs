// // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

// int [] CreateArrSize ()
// {
//     int Length = Random.Shared.Next(1,10);
//     int collection = int Length;
//     return collection;
// }

int [] CreateArr ()
{
    int Length = Random.Shared.Next(4,10);
    int [] collection = new int [Length];
    return collection;
}

void FillArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = Random.Shared.Next(1,10);
    }
}

//int[] array = {2, 1, 4, 5, 6, 3, 1 }; // Ввела массив вручную, чтобы проверить метод умножения

void PrintArray1 (int [] Numbers)
{
    int count = Numbers.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{Numbers[i]}");
    }
    Console.Write(" >>> ");
}

int[] Сomposition (int[] array)
{
    int count = array.Length / 2;
    int [] arrayResult = new int [count];
    for (int i = 0; i < count; i++) 
    {
       arrayResult [i]  = array[i] * array[array.Length - 1 - i];
    }
    return arrayResult;
}

void PrintArray (int[] collection) 
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collection[position]);
        position++;
    }
}

int [] collection = CreateArr();
FillArray(collection);
PrintArray1 (collection);
int []arrayResult = Сomposition (collection);
PrintArray (arrayResult);
