/*
Программа, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой черверти (x & Y)
*/

Console.WriteLine("Enter quarter coordinate: ");
int number = int.Parse(Console.ReadLine()!);

switch (number) {
    case 1:
        Console.WriteLine("Quarter 1: x > 0; y > 0");
        break;
    case 2:
        Console.WriteLine("Quarter 2: x < 0; y > 0");
        break;
    case 3:
        Console.WriteLine("Quarter 3: x < 0; y < 0");
        break;
    case 4:
        Console.WriteLine("Quarter 4: x > 0; y < 0");
        break;
    default:
        Console.WriteLine("You've inputed incorrect number! Quarter should be beween 1 and 4");
        break;
}