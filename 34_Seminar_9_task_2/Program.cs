/*
Написать программу, кторая покажет все числа от M до N.
Через рекурсию
*/

Console.WriteLine("Enter your num: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter your num: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(RecursionN(M, N));

string RecursionN (int m, int number) {
    if (m == number) {
        return number.ToString();
    }
    return (m + " " + RecursionN(m+1, number));
}