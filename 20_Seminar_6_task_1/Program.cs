/*
Написать программу, которая перевернет одномерный массив:
первый элемент будет последним, второй - предпоследним...
*/

int[] array = getArray(9);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] resultArrayReversed = reverseArrayTwo(array);
Console.WriteLine($"[{String.Join(", ", resultArrayReversed)}]");

reverseArrayOne(array);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] getArray(int size) {
    int[] array = new int[size];

    for (int i=0; i<array.Length; i++) {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}

void reverseArrayOne (int[] array) {
    for(int i=0; i<array.Length/2; i++) {
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

int[] reverseArrayTwo (int[] array) {
    int[] result = new int[array.Length];
    for (int i=0; i<array.Length; i++) {
        result[i] = array[array.Length - i - 1];
    }
    return result;
}