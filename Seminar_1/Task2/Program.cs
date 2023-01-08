// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7/ 44 78 5 -> 78/ 22 3 9 -> 22

int a = 22;
int b = 3;
int c = 9;
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.Write(max);