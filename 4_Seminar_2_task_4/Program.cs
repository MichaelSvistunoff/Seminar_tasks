/*
Напишите программу, которая на вход принимает одно число и проверяет, 
кратно ли оно одновременно 7 и 23
*/

Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine());

if ((number%7==0)&&(number%23==0)) {
    Console.WriteLine(("Your number ") + (number) + (" Has been divided by 7 and 23 succeessfully at the same time!"));
} else {
    Console.WriteLine("Error! Your number has't been divided by 7 and 23 succeessfully at the same time!");
}