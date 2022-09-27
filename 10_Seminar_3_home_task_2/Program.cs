Console.WriteLine("Choose number of operation: ");
int choosenNumber = int.Parse(Console.ReadLine());


if (choosenNumber==1) {

    Console.WriteLine("Enter number: ");
    int number = int.Parse(Console.ReadLine());
    if (number<100) {
        Console.WriteLine("Your number less then 100!");   
    } 
    int thirdNumber = 0; // Третья цифра числа

    if (number>99 && number<1000) {
        thirdNumber = (number%100)%10;
    }
    if (number>999 && number<10000) {
        thirdNumber = (number%100)/10;
    }
    if (number>9999 && number<100000) {
        thirdNumber = (number%1000)/100;
    }
    if (number>99999 && number<1000000) {
        thirdNumber = (number%10000)/1000;
    }

    Console.WriteLine($"Your third number is {thirdNumber}");
}

if (choosenNumber==2) {
    Console.WriteLine("Enter number: ");
    string number = Console.ReadLine();
    if (number.Length<3){
        Console.WriteLine("Error!");
    } else {
        Console.WriteLine($"Your third number {number} is {number[2]}");
    }
}