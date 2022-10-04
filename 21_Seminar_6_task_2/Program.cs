/*
Напистаь программу, которая на вход принимает три числа, и проверяет, может ли 
существовать треугольник со сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.WriteLine("Введите отрезок AB:");
int aB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите отрезок BC:");
int bC = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите отрезок CA:");
int cA = int.Parse(Console.ReadLine()!);

int result = getTheoreme(aB, bC, cA);
switch (result) {
    case 1:        
        Console.WriteLine("Well done! Theoreme is perfect!");
        break;
    default:
        Console.WriteLine("Error!");
        break;
}

int getTheoreme (int a, int b, int c) {
    int done = 0;
    for (int i=0; i<3;i++) {
        if ((a<=b+c) && (b<=c+a) && (c<=a+b)) {
            Console.WriteLine($"Done: AB({a}) <= BC({b}) + CA({c})!");
            Console.WriteLine($"Done: BC({b}) <= CA({c}) + AB({a})!");
            Console.WriteLine($"Done: CA({c}) <= AB({a}) + BC({b})!");
            done++;
            break;
        } else {
            Console.WriteLine("Error!");
            break;
        }
    }
    return done;
}