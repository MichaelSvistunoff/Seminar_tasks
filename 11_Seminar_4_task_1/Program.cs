/* 
Напишите программу, которая принимает на вход число А и выдает
сумму чисел от 1 до А

7 - 28
4 - 10
8 - 36
*/

Console.WriteLine("Enter Number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum from 1 to {number} = {GetSum(number)}");

int GetSum(int limit) {
    int sum = 0;
    for (int i = 1; i <= limit; i++) {
        sum = sum + i;
    }
    return sum;
}
