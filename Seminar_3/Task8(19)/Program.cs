// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет /12821 -> да /23432 -> да

Console.WriteLine("Введите пятизначное число ");
int Number5 = Convert.ToInt32(Console.ReadLine());

void ComparNumb (int B, int C)
{
    if (B == C)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}

int A = Number5 / 10000;
int B = Number5 / 1000 % 10;
int C = Number5 / 10 % 10;
int D = Number5 % 10;

if (A == D)
{
    ComparNumb (B, C);
}
else
{
    Console.WriteLine("Не палиндром");
}