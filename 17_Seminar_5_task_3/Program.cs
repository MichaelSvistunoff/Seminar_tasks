/*
Задать массив. Написать программу, которая определяет присутствует ли данное число в массиве
*/

int[] newArray = getArray(10);
Console.WriteLine($"[{String.Join(", ", newArray)}]");

Console.WriteLine("Введите число, которое нужно найти в массиве: ");
int findNumber = int.Parse(Console.ReadLine()!);

int aim = ifElemIsFound(newArray, findNumber);
switch (aim) {
    case -1:
        Console.WriteLine("Жаль! Твоего числа нет в массиве");
        break;
    default:
        Console.WriteLine($"Круто! Твоё число с индексом {aim}");
        break;
}

int[] getArray(int size) {
    int[] array = new int[size];

    for (int i=0; i<size; i++) {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int ifElemIsFound (int[] array, int find) {
    int position = -1;

    for (int i=0; i<array.Length; i++) {
        if (array[i]==find) {
            position=i;
            break;
        }
    }
    return position;
}