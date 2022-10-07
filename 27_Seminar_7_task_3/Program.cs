﻿/*
Задайте двумерный массив.
Найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты
*/

Console.WriteLine("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = getArray(rows, cols);
printArray(array);

int[,] getArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            if (i%2==0 && j%2==0) {
                newArray[i, j] = (i+j)*(i+j);
            } else {
                newArray[i, j] = i+j;
            }
        }
    }
    return newArray;
}

void printArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}