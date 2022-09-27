/*
Напишите программу, которая принимает на вхож число N и выдает произведение от 1 до N
4-24
5-120
*/

Console.WriteLine("Enter your number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"The multiplication of your number {N} = {GetMult(N)}");

int GetMult(int final) {
    int multiplication = 1;
    for (int i=2; i<=final; i++) {
        multiplication=multiplication*i;
    }
    return multiplication;
}