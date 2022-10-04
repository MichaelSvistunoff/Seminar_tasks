﻿/*
Не использую рекурсии, ввести первые N чисел фибоначчи.
Первые 2 числа 0 и 1.

Если N = 5 - 0 1 1 2 3
Если N = 3 - 0 1 1 
Если N = 7 - 0 1 1 2 3 5 8
*/

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int[] array = getArray(N);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] getArray(int size) {
    int[] array = new int[size];    
    array[0]=0;
    array[1]=1;
    for (int i=2; i<array.Length; i++) {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}