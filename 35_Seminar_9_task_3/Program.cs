/*
Напишите программу, которая будет принимать на вход число и будет возвращать сумму его цифр

453 - 12
*/

Console.WriteLine("Enter your number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSum(N));

int GetSum(int number) {
    if(number==0) {
        return 0;
    }
    return (number%10 + GetSum(number/10));
}