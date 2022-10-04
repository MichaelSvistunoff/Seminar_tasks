/*
Напишите программу, которая будет создавать копию заданного массива с помощью
поэлементного копирования
*/

int[] array = getArray(8);
Console.WriteLine($"Оригинальный массив: [{String.Join(", ", array)}]");

int[] arrayIsCopied = copyArray(array);
Console.WriteLine($"Скопированный массив: [{String.Join(", ", array)}]");

int[] getArray(int size) {
    int[] array = new int[size];

    for (int i=0; i<array.Length; i++) {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int[] copyArray(int[] arrayToCopy) {
    int[] coppiedArray = new int[arrayToCopy.Length];
    for (int i=0; i<arrayToCopy.Length; i++) {
        coppiedArray[i] = arrayToCopy[i];
    }
    return coppiedArray;
}