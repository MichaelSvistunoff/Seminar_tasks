/*
Напишите задачу по замене элементов массива с положительных на отрицательные и наоборот
*/

// Выозов массива
int[] array = getArray(4, -5, 5);
Console.WriteLine($"Массив оригинал: [{String.Join(" ", array)}]");

for (int i=0; i<array.Length; i++) {
    array[i] = array[i]*-1;
}
Console.WriteLine($"Массив после: [{String.Join(" ", array)}]");

// Создание метода генерации массива с заполнением
int[] getArray (int size, int startArray, int endArray) {
    int[] array = new int[size];

    for (int i=0; i<size; i++) {
        array[i] = new Random().Next(startArray, endArray+1);
    }
    return array;
}