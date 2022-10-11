/*
Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа выдаст ошибку.

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

После:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

Console.WriteLine("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = getArray(rows, cols);
printArray(array);
Console.WriteLine();

if (array.GetLength(0)==array.GetLength(1)) {
    int[,] newArray = printArrayReplaceElements(array);
    printArray(newArray);
} else {
    Console.WriteLine("Error!");
}

int[,] getArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            newArray[i,j] = new Random().Next(1, 10);
        }
    }
    return newArray;
}

void printArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] printArrayReplaceElements(int[,] array) { 
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
}