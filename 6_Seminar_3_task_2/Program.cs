/*
Напишите программу, которая принимает на вход координаты точки (Х != 0; У != 0) 
и выдает номер четверти, на которой находится эта точка
*/

Console.WriteLine("Enter X: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter Y: ");
int y = int.Parse(Console.ReadLine()!);

if ((x>0)&&(y>0)) {
    Console.WriteLine("You are on the 1-st quarter");
} else if ((x<0)&&(y>0)) {
    Console.WriteLine("You are on the 2-nd quarter");
} else if ((x<0)&&(y<0)) {
    Console.WriteLine("You are on the 3-th quarter");
} else if ((x>0)&&(y<0)) {
    Console.WriteLine("You are on the 4 quarter");
} else {
    Console.WriteLine("You are on the star of coordinater");
}