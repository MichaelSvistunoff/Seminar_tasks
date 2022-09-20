// Программу, которая выводит трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);

int numOne = number/100;
int numTwo = number%10;
int numThree = numOne*10 + numTwo;

Console.WriteLine(number);
Console.WriteLine(numThree);