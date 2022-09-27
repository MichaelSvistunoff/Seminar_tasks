/*
Напишите программу, которая принимает число и выдает количество цифр в числе
456 - 3
88 - 2
89126 - 5
*/

Console.WriteLine("Enter number: ");
string number = Console.ReadLine()!;

Console.WriteLine($"Your number {number} has digits: {GetDigits(int.Parse(number))}");
Console.WriteLine($"Your number {number} has digits: {GetDigitsStr(number)}");
Console.WriteLine($"Your number {number} has digits: {GetDigitsSimple(int.Parse(number))}");

int GetDigits(int number) {
    return (int)Math.Log10(number)+1;
}

int GetDigitsStr(string number) {
    return number.Length;
}

int GetDigitsSimple(int final) {
    int sum = 0;
    for (int i=final; final>0; sum++) {
        final=final/10;
    }
    return sum;
}