/*
Задать одномерный массив из 123 случайных чисел. Найти количество элементов массива,
значения которых лежат в отрезке [10, 99]
*/

int[] array = getArray(123);
Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine("Введите начало отрезка: ");
int startLength = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите конец отрезка: ");
int endLength = int.Parse(Console.ReadLine()!);

int aim = isFiltered(array, startLength, endLength);
Console.WriteLine($"Количество элементов, удовлетворяющих заданию: {aim}");

int[] getArray(int size) {
    int[] array = new int[size];

    for (int i=0; i<size; i++) {
        array[i] = new Random().Next(-200, 201);
    }
    return array;
}

int isFiltered(int[] filteredArray, int minValue, int maxValue) {
    int count = 0;
    for (int i=0;i<filteredArray.Length; i++) {
        if (filteredArray[i]>=minValue && filteredArray[i]<=maxValue) {
            count++;
        }
    }
    return count;
}