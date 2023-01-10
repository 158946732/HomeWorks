// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84   / A (7,-5, 0); B (1,-1,9) -> 15.65

int x1 = 3;
int x2 = 6;
int y1 = 8;
int y2 = 2;
int z1 = 1;
int z2 = -7;

double Distance = GetDistance(x1, x2, y1, y2, z1, z2);
Console.WriteLine(Distance);

double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}