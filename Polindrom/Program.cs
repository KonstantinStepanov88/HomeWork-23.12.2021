// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10000;
int num2 = (number / 1000) % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;
if (num1 == num5 && num2 == num4)
    Console.WriteLine("Это число палиндром");
else
    Console.WriteLine("Это число не палиндром");
