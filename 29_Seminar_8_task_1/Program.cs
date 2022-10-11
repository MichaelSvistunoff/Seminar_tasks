/*
Задать двумерный массив.
Написать программу, которая меняет первую и последнюю строку массива

1 4 7 2
5 9 2 3
8 4 2 4

После:
8 4 7 2
5 9 2 3
1 4 2 4
*/

Console.WriteLine("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = getArray(rows, cols);
printArray(array);
Console.WriteLine();
printArrayReplaceElements(array);
printArray(array);


int[,] getArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            newArray[i,j] = new Random().Next(1, 10);
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

void printArrayReplaceElements (int[,] array) {                  
    int maxStepRows = array.GetLength(0)-1;

    for (int i = 0; i < array.GetLength(1); i++) { 
        int tempOne = array[maxStepRows, i];
        array[maxStepRows, i] = array[0,i];
        array[0,i] = tempOne;
    }
}