// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число A - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B - ");
int numberB = int.Parse(Console.ReadLine());
if ( numberA == numberB * numberB)
    Console.WriteLine("Число А является квадратом числа B");
else
    if ( numberB == numberA * numberA)
        Console.WriteLine("Число B является квадратом числа А");
    else
        Console.WriteLine("ни одно число не является квадратом другого");
