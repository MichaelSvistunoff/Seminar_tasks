/*
Напистаь программу, которая будет преобразовывать десятичное число в двоичное

45 - 101101
3 - 11
2 - 10
*/

Console.WriteLine("Введите число для перевода в двоичную систему: ");
int num = int.Parse(Console.ReadLine()!);

int resultSteps = countSteps(num);
Console.WriteLine($"Количество шагов: {resultSteps}");

int[] resultNumberInDouble = getNumberInDoubleSystem(resultSteps, num);
Console.WriteLine($"[{String.Join(", ", resultNumberInDouble)}]");

reverseArray(resultNumberInDouble);
Console.WriteLine($"[{String.Join(", ", resultNumberInDouble)}]");

int countSteps(int number) {
    int count = 0;
    int sum = number;
    for (int i=0; sum>=1; i++) {
        sum = sum/2;
        count++;
    }
    return count;
}

int[] getNumberInDoubleSystem (int size, int number) {
    int[] array = new int[size];
    int temp = number;
    for (int i=0; i<size; i++) {
        if (temp%2==0) {
            temp = temp/2;
            array[i] = 0;
        } else {
            temp = temp/2;
            array[i] = 1;
        }
    }
    return array;
}

void reverseArray (int[] array) {
    for (int i=0; i<array.Length/2; i++) {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}