/*
Написать программу, кторая покажет все числа от 1 до N.
Через рекурсию
*/

Console.WriteLine("Enter your num: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(RecursionN(1, n));

string RecursionN (int minVal, int number) {
    if (minVal == number) {
        return number.ToString();
    }
    return (minVal + " " + RecursionN(minVal+1, n));
}