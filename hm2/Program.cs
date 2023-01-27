// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

int x1 = ReadInt("Введите X координату для первой точки:");
int y1 = ReadInt("Введите Y координату для первой точки:");
int z1 = ReadInt("Введите Z координату для первой точки:");
int x2 = ReadInt("Введите X координату для второй точки:");
int y2 = ReadInt("Введите Y координату для второй точки:");
int z2 = ReadInt("Введите Z координату для второй точки:");

int A = x2-x1;
int B = y2-y1;
int C = z2-z1;

double len = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {len}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}