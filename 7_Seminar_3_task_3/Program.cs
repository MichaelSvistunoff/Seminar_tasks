/*
Написать программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве

А(3, 6) В(2, 1)     -> 5, 09
A(7, -5) B(1, -1)   -> 7, 21

Math.Sqrt
*/

Console.WriteLine("Enter starting cordinat X: ");
int xD = int.Parse(Console.ReadLine());

Console.WriteLine("Enter starting cordinat Y: ");
int yD = int.Parse(Console.ReadLine());

Console.WriteLine("Enter ending cordinat X: ");
int xF = int.Parse(Console.ReadLine());

Console.WriteLine("Enter ending cordinat Y: ");
int yF = int.Parse(Console.ReadLine());

double resultPoint = Math.Sqrt(Math.Pow(xF-xD, 2)+Math.Pow(yF-yD, 2));

Console.WriteLine($"Your result is {resultPoint:f2}");
Console.WriteLine($"Your result is {Math.Round(resultPoint, 2, MidpointRounding.ToNegativeInfinity)}");