// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double allX = Math.Pow(X1 - X2, 2);
double allY = Math.Pow(Y1 - Y2, 2);
double allZ = Math.Pow(Z1 - Z2, 2);
double result = Math.Sqrt(allX + allY + allZ);
Console.WriteLine($"{result:f2}");
