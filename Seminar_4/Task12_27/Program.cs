// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 //  82 -> 10 //  9012 -> 12

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int digit)                     
{
    int count = Convert.ToString(digit).Length;
    int motion = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      motion = digit - digit % 10;
      result = result + (digit - motion);
      digit = digit / 10;
    }
   return result;
  }

int digit = GetNumber();
int sum = Sum(digit);
Console.WriteLine(sum);

