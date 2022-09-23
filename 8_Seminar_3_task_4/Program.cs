/*
Напишите программу, которая на вход принимает число N,
а на выходе показывает все четные числа от 1 до N
*/

Console.WriteLine("Enter number (>0): ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++) {
    if (i%2==0){
        Console.Write($"{i} ");
    }
}