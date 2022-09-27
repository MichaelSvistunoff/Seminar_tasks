/*
Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке
*/

int [] ar = fillArray(8);
Console.WriteLine($"[{String.Join(", ", ar)}]");
// printArray(ar);

int [] fillArray(int size) {
    int [] array = new int[size];
    for (int i=0; i<size; i++) {
        array [i] = new Random().Next(0,2);
    }
    return array;
}

// void printArray(int [] arr){
//     for (int i=0; i<arr.Length; i++) {
//         Console.Write($"{arr[i]} ");
//     }
// }