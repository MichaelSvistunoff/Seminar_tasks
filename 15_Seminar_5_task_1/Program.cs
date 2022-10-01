/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9; 9].
Найти сумму положительных и отрицательных элементов массива
*/

// 2. Вызов массива
int [] array = getArray(12, -9, 9);
Console.WriteLine(string.Join(" ", array));

// 3. Введение держателей сумм (+/-)
int positiveSum = 0;
int negativeSum = 0;

// 4. Выборка по положительным и отрицательным элементам
for (int i=0; i<array.Length; i++) {
    if (array[i]<0){
        negativeSum += array[i];
    } else {
        positiveSum += array[i];
    }
}

Console.WriteLine($"Сумма положительных: {positiveSum}. Сумма отрицательных: {negativeSum}");

// 1. Создание метода массива по условиям задачи
int[] getArray(int size, int minValue, int maxValue) {
    int[] newArray = new int[size];
    for (int i=0; i<size; i++) {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}