/*
Задайте двумерный массив размера M*N.
Каждый элемент в массиве находится по формуле Amn = m+n.
Выведите полученный массив.

m = 4, n = 3
0 1 2 3
1 2 3 4
2 3 4 5
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
            newArray[i, j] = i+j;
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