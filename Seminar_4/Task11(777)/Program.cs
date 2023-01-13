// Напишите программу, которая выводит массив из N элементов, 
// заполненный нулями и единицами в случайном порядке. Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное.

int GetNumber()
{
    Console.Write("Введите число ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

void FillArray(int[] bin)
{
    int count = bin.Length;
    for (int i = 1; i < count; i++)
    {
        bin[0] = 1;
        bin[i] = Random.Shared.Next(0, 2);
    }

}

int BinToDec(int[] arrayBin)
{
    int count = arrayBin.Length - 1;
    int result = 0;
    for (int i = 0; i < arrayBin.Length; i++)
    {
        if (arrayBin[i] == 1)
        {
           result = result + Convert.ToInt32(Math.Pow(2, count));
        }
      count = count - 1;
    }
    return result;
}


string BeautyPrint(int[] arrBin, int dec)
{
    return $"{String.Join("", arrBin)} >> {dec}";
}

int size = GetNumber();
int[] array = CreateArray(size);
FillArray(array);
int result = BinToDec(array);
Console.WriteLine(BeautyPrint(array, result));


