/*
Задайт двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали (с идексами 0,0; 1,1...)
*/

Console.WriteLine("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = getArray(rows, cols);
printArray(array);
Console.WriteLine($"Сумма элементов главной дагонали: {findSum(array)}");

int[,] getArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            if (i==j) {
                newArray[i, j] = i+j;
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

int findSum (int[,] array) {
    int sum = 0;
    for (int i=0; i<array.GetLength(0); i++) {
        for (int j=0; j<array.GetLength(1); j++) {
            if(i==j) {
                sum = sum + (i+j);
            }
        }
    }
    return sum;
}