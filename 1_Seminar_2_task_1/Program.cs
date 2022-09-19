/* 
Напишите программу, которая выводит случайные числа 
из отрезка [10; 99] и показывает наибольшую цифру числа
*/

int number  = new Random().Next(10, 100);    // От 10 до 99: правая граница НЕ включается
int numOne  = number/10;                     // Берем первое число: 92 -> 9.2 = 9
int numTwo  = number%10;                     // Берем второе число: 92 -> 9.2 = 2

// Вариант решения 1
int max     = numOne;                        // Пока Max - numOne
if (max<numTwo) max = numTwo;

// Вариант решения 2
// int max     = Math.Max(numOne, numTwo);

Console.WriteLine($"Число - {number}: его первое число - {numOne}, второе - {numTwo}. Наибольшая цира числа - {max}");