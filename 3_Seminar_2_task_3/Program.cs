/* 
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому.
Если второе число НЕ кратно первому, то выводим остаток от деления
34, 5 -> Не кртно, остаток 4
16, 4 -> Кратно
*/

Console.WriteLine("Enter first number: ");      // Вводим первое число
int numOne = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");     // Вводим второе чисто
int numTwo = int.Parse(Console.ReadLine());

// int numOne = new Random().Next(1, 100);      // Рандомайзер первого числа
// int numTwo = new Random().Next(1, 10);       // Рандомайзер второго числа

if (numOne%numTwo==0) {
    Console.WriteLine(("Все верно! ") + (numOne ) + (" / ") + (numTwo) + (" = ") + (numOne/numTwo));
} else {
    Console.WriteLine((numOne ) + (" ") + (numTwo) + (". Не кртно. Остаток - ") + (numOne/numTwo));
}
