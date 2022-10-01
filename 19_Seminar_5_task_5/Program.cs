/*
Найти произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний, второй и предпоследний и тд. элемент
[1, 2, 3, 4, 5] -> 1*5=5 2*4=8 3
[6, 7, 3, 6]
*/

int[] array = getArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] newArray = arrayToMoveElem(array);
Console.WriteLine($"[{String.Join(", ", newArray)}]");

int[] getArray(int size) {
    int[] array = new int[size];

    for (int i=0; i<array.Length; i++) {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

int[] arrayToMoveElem (int[] array) {

    // int arraySize = 0;
    // if (array.Length%2==0) {
    //     arraySize = array.Length/2;
    // } else {
    //     arraySize = array.Length/2+1;
    // }

    int arraySize = (int)Math.DivRem(array.Length, 2, out int result) + result;

    int[] newArray = new int[arraySize];
    for (int i=0, j=array.Length-1; i<arraySize; i++, j--) {
        if (i!=j){
            newArray[i] = array[i]*array[j];
        } else {
            newArray[i] = array[i];
        }
    }
    return newArray;
}