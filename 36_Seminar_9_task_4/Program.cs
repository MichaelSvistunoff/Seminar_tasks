/*
Написать программу, которая на вход принимает 2 числа A и B.
И возводит число A в целую степень B через рекурсию

A = 3, B = 5 => 243
A = 2, B = 3 => 8
*/

Console.WriteLine("Enter A: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter A: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetResultOfAInB(A, b));

int GetResultOfAInB (int number, int extent) {
    if (extent == 0) return 1;
    else if (extent == 1) return number;
    return number * GetResultOfAInB(number, extent-1);
}